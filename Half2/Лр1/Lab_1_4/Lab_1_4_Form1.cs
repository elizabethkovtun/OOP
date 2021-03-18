using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_4
{
    public partial class Form1 : Form
    {
        int count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Label" + count.ToString();
            label.Font = new Font("Arial", 10, FontStyle.Bold);
            label.Location = new Point(10, 50 * count);
            this.Controls.Add(label);
            count++;

        }
        private void label_Click(object sender, EventArgs e)
        {
           
        }
    }
}
