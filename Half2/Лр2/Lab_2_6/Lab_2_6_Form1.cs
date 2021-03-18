using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_6_
{
    public partial class Form1 : Form
    {
        delegate void Delegates(object sender, EventArgs e);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Azure;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
           
            if (this.Opacity == 0.7f)
            {
                this.Opacity = 1f;
            }
            else
            {
                this.Opacity = 0.7f;
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delegates[] buttons = new Delegates[3] { button1_Click, button2_Click, button3_Click };
            MessageBox.Show("Це суперкнопка!");
            if (checkBox1.Checked == true)
            {
                buttons[1](sender, e);
            }
            if (checkBox2.Checked == true)
            {
                buttons[0](sender, e);
            }
            if (checkBox3.Checked == true)
            {
                buttons[2](sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}

        
