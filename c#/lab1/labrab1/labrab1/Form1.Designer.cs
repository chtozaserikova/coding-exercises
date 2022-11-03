namespace labrab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstTo = new System.Windows.Forms.ListBox();
            this.lstFrom = new System.Windows.Forms.ListBox();
            this.lstSearchResults = new System.Windows.Forms.ListBox();
            this.txtFileContents = new System.Windows.Forms.TextBox();
            this.SortOrderFrom = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkSection1 = new System.Windows.Forms.CheckBox();
            this.chkSection2 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.rdoEmails = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoDigits = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SortOrderTo = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button14 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTo
            // 
            this.lstTo.FormattingEnabled = true;
            this.lstTo.Location = new System.Drawing.Point(268, 44);
            this.lstTo.Name = "lstTo";
            this.lstTo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTo.Size = new System.Drawing.Size(157, 199);
            this.lstTo.TabIndex = 0;
            this.lstTo.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstFrom
            // 
            this.lstFrom.FormattingEnabled = true;
            this.lstFrom.Location = new System.Drawing.Point(15, 44);
            this.lstFrom.Name = "lstFrom";
            this.lstFrom.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstFrom.Size = new System.Drawing.Size(156, 199);
            this.lstFrom.TabIndex = 1;
            // 
            // lstSearchResults
            // 
            this.lstSearchResults.FormattingEnabled = true;
            this.lstSearchResults.Location = new System.Drawing.Point(6, 63);
            this.lstSearchResults.Name = "lstSearchResults";
            this.lstSearchResults.Size = new System.Drawing.Size(150, 95);
            this.lstSearchResults.TabIndex = 2;
            // 
            // txtFileContents
            // 
            this.txtFileContents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileContents.Location = new System.Drawing.Point(451, 27);
            this.txtFileContents.Multiline = true;
            this.txtFileContents.Name = "txtFileContents";
            this.txtFileContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFileContents.Size = new System.Drawing.Size(249, 503);
            this.txtFileContents.TabIndex = 3;
            // 
            // SortOrderFrom
            // 
            this.SortOrderFrom.FormattingEnabled = true;
            this.SortOrderFrom.Items.AddRange(new object[] {
            "Алфавиту (возрастанию)",
            "Алфавиту (убыванию)",
            "Кол-ву букв в словах (возрастанию)",
            "Кол-ву букв в словах (убыванию)"});
            this.SortOrderFrom.Location = new System.Drawing.Point(15, 17);
            this.SortOrderFrom.Name = "SortOrderFrom";
            this.SortOrderFrom.Size = new System.Drawing.Size(156, 21);
            this.SortOrderFrom.TabIndex = 4;
            this.SortOrderFrom.Text = "Сортировка по ...";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(177, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 186);
            this.panel1.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkSection1
            // 
            this.chkSection1.AutoSize = true;
            this.chkSection1.Checked = true;
            this.chkSection1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSection1.Location = new System.Drawing.Point(9, 164);
            this.chkSection1.Name = "chkSection1";
            this.chkSection1.Size = new System.Drawing.Size(72, 17);
            this.chkSection1.TabIndex = 7;
            this.chkSection1.Text = "Раздел 1";
            this.chkSection1.UseVisualStyleBackColor = true;
            // 
            // chkSection2
            // 
            this.chkSection2.AutoSize = true;
            this.chkSection2.Location = new System.Drawing.Point(9, 187);
            this.chkSection2.Name = "chkSection2";
            this.chkSection2.Size = new System.Drawing.Size(72, 17);
            this.chkSection2.TabIndex = 8;
            this.chkSection2.Text = "Раздел 2";
            this.chkSection2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.SortOrderTo);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.lstFrom);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lstTo);
            this.panel2.Controls.Add(this.SortOrderFrom);
            this.panel2.Location = new System.Drawing.Point(12, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 501);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.rdoEmails);
            this.groupBox2.Controls.Add(this.rdoAll);
            this.groupBox2.Controls.Add(this.rdoDigits);
            this.groupBox2.Location = new System.Drawing.Point(185, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 91);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор слов";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(142, 29);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(57, 39);
            this.button11.TabIndex = 15;
            this.button11.Text = "Начать";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // rdoEmails
            // 
            this.rdoEmails.AutoSize = true;
            this.rdoEmails.Location = new System.Drawing.Point(9, 63);
            this.rdoEmails.Name = "rdoEmails";
            this.rdoEmails.Size = new System.Drawing.Size(131, 17);
            this.rdoEmails.TabIndex = 2;
            this.rdoEmails.Text = "Содержащие \"e-mail\"";
            this.rdoEmails.UseVisualStyleBackColor = true;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(9, 17);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(44, 17);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "Все";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoDigits
            // 
            this.rdoDigits.AutoSize = true;
            this.rdoDigits.Location = new System.Drawing.Point(9, 40);
            this.rdoDigits.Name = "rdoDigits";
            this.rdoDigits.Size = new System.Drawing.Size(128, 17);
            this.rdoDigits.TabIndex = 1;
            this.rdoDigits.Text = "Содержащие цифры";
            this.rdoDigits.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lstSearchResults);
            this.groupBox1.Controls.Add(this.txtToFind);
            this.groupBox1.Controls.Add(this.chkSection2);
            this.groupBox1.Controls.Add(this.chkSection1);
            this.groupBox1.Location = new System.Drawing.Point(15, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 215);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Введите искомое слово";
            // 
            // txtToFind
            // 
            this.txtToFind.Location = new System.Drawing.Point(6, 37);
            this.txtToFind.Name = "txtToFind";
            this.txtToFind.Size = new System.Drawing.Size(150, 20);
            this.txtToFind.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Раздел 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Раздел 1";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(350, 436);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 16;
            this.button12.Text = "Сброс";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(350, 465);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 15;
            this.button13.Text = "Закрыть";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(268, 249);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 23);
            this.button9.TabIndex = 14;
            this.button9.Text = "Сортировать";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(350, 249);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Очистить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // SortOrderTo
            // 
            this.SortOrderTo.FormattingEnabled = true;
            this.SortOrderTo.Items.AddRange(new object[] {
            "Алфавиту (возрастанию)",
            "Алфавиту (убыванию)",
            "Кол-ву букв в словах (возрастанию)",
            "Кол-ву букв в словах (убыванию)"});
            this.SortOrderTo.Location = new System.Drawing.Point(268, 17);
            this.SortOrderTo.Name = "SortOrderTo";
            this.SortOrderTo.Size = new System.Drawing.Size(157, 21);
            this.SortOrderTo.TabIndex = 11;
            this.SortOrderTo.Text = "Сортировка по ...";
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(96, 249);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Очистить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(15, 249);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Сортировать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "srthjwrj";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem2.Text = "?";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(87, 165);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(57, 39);
            this.button14.TabIndex = 16;
            this.button14.Text = "Поиск";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtFileContents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTo;
        private System.Windows.Forms.ListBox lstFrom;
        private System.Windows.Forms.ListBox lstSearchResults;
        private System.Windows.Forms.TextBox txtFileContents;
        private System.Windows.Forms.ComboBox SortOrderFrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkSection1;
        private System.Windows.Forms.CheckBox chkSection2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox SortOrderTo;
        private System.Windows.Forms.RadioButton rdoEmails;
        private System.Windows.Forms.RadioButton rdoDigits;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.TextBox txtToFind;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button14;
    }
}

