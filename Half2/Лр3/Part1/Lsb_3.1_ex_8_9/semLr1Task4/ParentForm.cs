using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semLr1Task4
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;
        public ParentForm()
        {
            InitializeComponent();
            //Властивості Text панелі spData установлюється поточна дата
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
            
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm1 newChild = new ChildForm1();
            newChild.MdiParent = this;
            newChild.Text = newChild.Text + " " + ++openDocuments;
            newChild.Show();
        }

        private void ToolStrip1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm1 newChild = new ChildForm1();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = newChild.Text + " " + ++openDocuments;
                    break;
                case"Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    break;
                case"Tіtle":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    break;
            }
        }

        private void SpWіn_Click(object sender, EventArgs e)
        {
            spWіn.Text = "Wіndows іs cascade";
            spWіn.Text = "Wіndows іs horіzontal";
        }

        private void SpData_Click(object sender, EventArgs e)
        {
            
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

    }
}
