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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || (textBox1.Text == "" && textBox2.Text == ""))
            {
                MessageBox.Show("Fill in the gapse: name or address", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if  (textBox1.Text != "" && textBox2.Text != "")
            {
                this.Close();
                Form3 form3 = new Form3();
                form3.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Audrey Hepburn";
            textBox2.Text = "Los-Angeles, Beverly Hills, 20";
            textBox3.Text = "Goes to the doctor Bern";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo = new OpenFileDialog();
            photo.Filter = "Image Files(*.BMP; *.GPG;*.GIF;*.PNG)|*.BMP; *.GPG;*.GIF;*.PNG|All files(*.*)|*.*";
            if(photo.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(photo.FileName);
                }
                catch
                {
                    MessageBox.Show("Can't choose this file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
