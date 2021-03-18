using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Dodatkove
{
    public partial class Form3 : Form
    {
        int bill;
        public Form3()
        {
            InitializeComponent();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            

        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public int Bill()
        {
            int bill = 0;
            if (checkBox1.Checked == true)
            {
                bill += 100;
            }
            if (checkBox2.Checked == true)
            {
                bill += 150;
            }
            if (checkBox3.Checked == true)
            {
                bill += 175;
            }
            if (checkBox4.Checked == true)
            {
                bill += 75;
            }
            if (checkBox5.Checked == true)
            {
                bill += 100;
            }
            if (checkBox6.Checked == true)
            {
                bill += 200;
            }
            return bill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bill = Bill();
            textBox1.Text = Convert.ToString(bill);
        }
    }
}
