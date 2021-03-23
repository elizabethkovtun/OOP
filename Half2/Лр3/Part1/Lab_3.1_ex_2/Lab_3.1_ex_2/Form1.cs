using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3._1_ex_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(peopleList.Text.Length!=0)
            {
                membersList.Items.Add(peopleList.Text);
            }
            else
            {
                MessageBox.Show("Виберіть елемент зі списку або введіть новий");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while(membersList.CheckedIndices.Count>0)
            {
                membersList.Items.RemoveAt(membersList.CheckedIndices[0]);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            membersList.Sorted = true;
        }
    }
}
