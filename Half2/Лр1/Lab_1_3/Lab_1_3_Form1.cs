using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mouse_enter(object sender, EventArgs e)
        {
            button1.BackColor = Color.YellowGreen;
        }

        private void mouse_leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.BlueViolet;
        }
    }
}
