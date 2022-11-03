using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            oleDbSelectCommand1.CommandText = "SELECT CustomerID, CompanyName FROM Customers\r\n" + "WHERE (CompanyName LIKE ? + '%')";
            oleDbSelectCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter());
            oleDbSelectCommand1.Parameters[0].Value = "A";

            oleDbDataAdapter1.Fill(dataSet11);

            listBox.SelectedIndex = listBox.Items.Count - 1;



            //oleDbDataAdapter1.Fill(dataSet11);

           // listBox.SelectedIndex = listBox.Items.Count - 1;

        }

        private void btnLoadList_Click(object sender, EventArgs e)
        {
            NewLoad();
        }

        void NewLoad()
        {
            String text = txtCustLimit.Text.Trim();
            txtCustLimit.Text = text;
            oleDbSelectCommand1.Parameters[0].Value = text;

            dataSet11.Clear();

            oleDbDataAdapter1.Fill(dataSet11);
            listBox.SelectedIndex = listBox.Items.Count - 1;

        }

        private void txtCustLimit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                NewLoad();
        }

        private void TxtCustLimit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
