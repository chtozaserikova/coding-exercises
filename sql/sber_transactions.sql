/*
Данные
1. Транзакции между компаниями.
COMPANY_FROM: string - Имя компании отправителя
COMPANY_TO: string - Имя компании получателя
AMOUNT: long - Сумма транзакции
TRANSACTION_ID long - Идентификатор транзакции
Наименование таблицы должно быть trans

2. Справочник регионов, в которых зарегистрированы компании
REGION: string - Имя региона
COMPANIES: string - Список компаний зарегистрированных в этом регионе, написаны через запятую
Загрузить справочник в таблицу нужно в исходном формате.
Наименование таблицы должно быть dict

Ожидаемый результат:
1. Итоговая таблица
По каждому региону собрать зарегистрированные в нем компании, их баланс, количество транзакций.
Отсортировать по региону и по убывающей прибыли
REGION: string - Имя региона 
COMPANY_COUNT: string – количество компаний в регионе
COMPANY: string - Имя компании
BALANCE: long - Баланс компании
COUNT: long - Количество транзакций
LAST_TRANSACTION_ID: long – идентификатор последней транзакции 
LAST_AMOUNT: long – сумма последней транзакции
FLAG: boolean – Творческая колонка.  Добавить бинарный признак можно ли отнести компанию к категории “прокси/посредник”. Компании этой категории характерны высокие обороты при нулевом балансе
*/

with companies
as (
  select distinct lower(region) as region,
  TRIM(BOTH FROM unnest(string_to_array(upper(dict.companies), ','))) as company
  from dict
),
companies_count as (
  select region, company,
      count(company) over (partition by region) as company_count
  from companies
  group by region, company
),
companies_from as (
  select company_from, sum(amount) as amount_from from trans group by company_from
),
companies_to as (
  select company_to, sum(amount) as amount_to from trans group by company_to
),
balance as (     -- формула баланса с группировкой по компании = сумма платежей, где компания в "TO" - сумма платежей, где компания в "FROM"
	select company_to, company_from, (amount_to - amount_from) AS balance
	from companies_from
	join companies_to on company_from = company_to
),
trans_plus as 	-- 	список компаний, принимающих платежи
	(
	SELECT company_to as comp, transaction_id, amount
	FROM trans
	),
	full_trans as (	-- 	Все транзакции с группировкой по компаниям (добавили список компаний, отправляющих платежи)
	SELECT * FROM
	(
		(SELECT company_from as comp, transaction_id, amount
		FROM trans)
		UNION ALL(SELECT * FROM trans_plus)
	) t1
),
stats as (    -- считаем суммарное количество транзакций каждой компании и находим последнню транзакций (+ее сумма)
	SELECT * FROM (
		SELECT comp, count(DISTINCT transaction_id) as count
		FROM full_trans
		GROUP BY comp
		) t1
	LEFT JOIN 
	  ( 
	  SELECT t2.comp, t2.transaction_id, amount as last_amount FROM 
	   ( 
	   SELECT 
	    comp, 
	    MAX(transaction_id) as transaction_id 
	   FROM full_trans 
	   GROUP BY comp 
	   ) t2 
	  LEFT JOIN trans_plus USING(transaction_id) 
	  ) t3 USING (comp) 
)
select region,
    company_count,
    c.company,
    b.balance,
    count,
    stats.transaction_id as last_transaction_id, 
    stats.last_amount, 
    case 
      when abs(b.balance) < 1000000 and count > 10000 then true 
      else false 
    end as FLAG
from companies_count c
join trans t
on c.company = t.company_from
join balance b
on t.company_from = b.company_from
left join stats
on stats.comp = t.company_from
group by region, company_count, c.company, b.balance, count, stats.transaction_id, last_amount