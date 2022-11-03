using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labrab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //cancel
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.lstAdd1(this.textBox1.Text);
            get_value();
            this.Close();
        }

        public bool is_to_from()
        {
            return this.radioButton1.Checked;
        }

        public string get_value()
        {
            return this.textBox1.Text;
        }
    }
}
