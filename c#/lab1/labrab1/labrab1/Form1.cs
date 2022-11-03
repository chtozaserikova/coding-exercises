using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labrab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Form()
        {
            Application.Exit();
        }

        //remove all from
        private void button8_Click(object sender, EventArgs e)
        {
            lstFrom.Items.Clear();
        }

        private void btnSortSection1_Click(object sender, EventArgs e)
        {
            
        }
        private void btnSortSection2_Click(object sender, EventArgs e)
        {
            
        }

        private void sort_list(ListBox list, ComboBox cbox)
        {
            this.Cursor = Cursors.WaitCursor;
            string order = cbox.Text.ToString();
            if (order == "Алфавиту (убыванию)")
            {
                ArrayList q = new ArrayList();
                foreach (object o in list.Items)
                { q.Add(o); }
                q.Sort();
                list.Items.Clear();
                foreach (object o in q)
                {
                    list.Items.Add(o);
                }
            }
            else if (order == "Алфавиту (возрастанию)")
            {
                ArrayList q = new ArrayList();
                foreach (object o in list.Items)
                { q.Add(o); }
                q.Sort();
                q.Reverse();
                list.Items.Clear();
                foreach (object o in q)
                {
                    list.Items.Add(o);
                }
            }
            else if (order == "Кол-ву букв в словах (возрастанию)")
            {
                ArrayList q = new ArrayList();
                foreach (object o in list.Items)
                { q.Add(o); }
                var x = q.Cast<string>().OrderBy(str => str.Length).ThenBy(str => str);
                list.Items.Clear();
                foreach (object o in x)
                {
                    list.Items.Add(o);
                }
            }
            else if (order == "Кол-ву букв в словах (убыванию)")
            {
                ArrayList q = new ArrayList();
                foreach (object o in list.Items)
                { q.Add(o); }
                var y = q.Cast<string>().OrderBy(str => str.Length).ThenBy(str => str).Reverse();
                list.Items.Clear();
                foreach (object o in y)
                {
                    list.Items.Add(o);
                }
            }
            else
            {
                MessageBox.Show("Выберите критерий сортировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Cursor = Cursors.Default;
        }

        //sort from
        private void button7_Click(object sender, EventArgs e)
        {
            sort_list(lstFrom, SortOrderFrom);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            lstFrom.Items.Clear();
            lstTo.Items.Clear();
            lstSearchResults.Items.Clear();
            txtFileContents.Clear();
            chkSection1.Checked = true;
            chkSection2.Checked = false;
            rdoAll.Checked = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //sort to
        private void button9_Click(object sender, EventArgs e)
        {
            sort_list(lstTo, SortOrderTo);
        }
        //remove all to
        private void button10_Click(object sender, EventArgs e)
        {
            lstTo.Items.Clear();
        }

        //open txt file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(dlg.FileName, Encoding.Default);
                txtFileContents.Text = reader.ReadToEnd();
                reader.Close();
            }
            dlg.Dispose();
        }

        //authors
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Серикова С.С. ПИ-3-3");
        }

        //exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit_Form();
        }

        //save txt file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);
                for (int i = 0; i < lstTo.Items.Count; i++)
                {
                    writer.WriteLine((string)lstTo.Items[i]);
                }
                writer.Close();
            }
            dlg.Dispose();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            exit_Form();
        }

        private void DeleteSelectedItems(ListBox lstFrom1)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstFrom1);
            selectedItems = lstFrom1.SelectedItems;
            if (lstFrom1.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    lstFrom1.Items.Remove(selectedItems[i]);
            }
        }

        //moving selected items
        private void MoveSelectedItems(ListBox lstFrom, ListBox lstTo)
        {
            lstTo.BeginUpdate();
            foreach (object item in lstFrom.SelectedItems)
            {
                lstTo.Items.Add(item);
            }
            DeleteSelectedItems(lstFrom);
            lstTo.EndUpdate();
        }

        //moving all items
        private void MoveAllItems(ListBox lstFrom, ListBox lstTo)
        {
            lstTo.Items.AddRange(lstFrom.Items);
            lstFrom.Items.Clear();
        }



        //start
        private void button11_Click(object sender, EventArgs e)
        {
            lstFrom.Items.Clear();
            lstTo.Items.Clear();
            lstFrom.BeginUpdate();
            string[] strings = txtFileContents.Text.Split(new char[] { '\n', '\t', ' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in strings)
            {
                string str = s.Trim();
                if (str == String.Empty)
                    continue;
                if (rdoAll.Checked)
                {
                    lstFrom.Items.Add(str);
                }
                if (rdoDigits.Checked)
                {
                    if (Regex.IsMatch(str, @"\d"))
                        lstFrom.Items.Add(str);
                }
                if (rdoEmails.Checked)
                {
                    if (Regex.IsMatch(str, @"\w+@\w+\.\w+"))
                        lstFrom.Items.Add(str);
                }
            }
            lstFrom.EndUpdate();
        }
        //move to the left from right
        private void button1_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lstFrom, lstTo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lstTo, lstFrom);
        }

        //move all to the left
        private void button3_Click(object sender, EventArgs e)
        {
            MoveAllItems(lstFrom, lstTo);
        }

        //move all to the right
        private void button4_Click(object sender, EventArgs e)
        {
            MoveAllItems(lstTo, lstFrom);
        }

        //delete items
        private void button6_Click(object sender, EventArgs e)
        {
            DeleteSelectedItems(lstFrom);
            DeleteSelectedItems(lstTo);
        }

        public void lstAdd1(string value)
        {
            lstFrom.Items.Add(value.Trim());
        }
        public void lstAdd2(string value)
        {
            lstTo.Items.Add(value.Trim());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
            if (fm2.is_to_from())
            {
                lstFrom.Items.Add(fm2.get_value());
            }
            else
            {
                lstTo.Items.Add(fm2.get_value());
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lstSearchResults.Items.Clear();
            string textToFind = txtToFind.Text;
            if (chkSection1.Checked)
            {
                foreach (string s in lstFrom.Items)
                {
                    if (s.Contains(textToFind))
                        lstSearchResults.Items.Add(s);
                }
            }
            if (chkSection2.Checked)
            {
                foreach (string s in lstTo.Items)
                {
                    if (s.Contains(textToFind))
                        lstSearchResults.Items.Add(s);
                }
            }

        }
    }
}
