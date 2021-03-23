using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3._1_ex_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult aResult;
            Form2 aForm = new Form2();
            aResult = aForm.ShowDialog();
            if(aResult==System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Yourr name is" + aForm.textBox1.Text + " " + aForm.textBox2.Text);
            }
            linkLabel1.LinkVisited = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            System.Diagnostics.Process.Start("http://www.google.com/");

            linkLabel2.LinkVisited = true;
        }
    }
}
