using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3._2
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void New_object_Click(object sender, EventArgs e)
        {

            count++;
            int Size = rand.Next(10, 300);
            int rand1 = rand.Next(0, 679 - Size);
            int rand2 = rand.Next(0, 525 - Size);

            PPicture figure = new PPicture(rand1, rand2, Size, "Picture " + count, Color.Red);
            figure.Show();
            figure.Draw(pictureBox1);
            comboBox1.Items.Add(figure);
        }

        private void Hide_object_Click(object sender, EventArgs e)
        {
            PPicture figure = (PPicture)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
        }

        private void Show_object_Click(object sender, EventArgs e)
        {
            PPicture figure = (PPicture)comboBox1.SelectedItem;
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Up_1_Click(object sender, EventArgs e)
        {
            PPicture figure = (PPicture)comboBox1.SelectedItem;
            if (figure.clr == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.EndUp();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Up_Click(object sender, EventArgs e)
        {
            PPicture figure = (PPicture)comboBox1.SelectedItem;
            if (figure.clr == Color.White) return;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveUp();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            PPicture figure = (PPicture)comboBox1.SelectedItem;
            if (figure.clr == Color.White) return;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Enlarge();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            PPicture figure = (PPicture)comboBox1.SelectedItem;
            if (figure.clr == Color.White) return;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Reduce();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Down_Click(object sender, EventArgs e)
        {
            PPicture figure = (PPicture)comboBox1.SelectedItem;
            if (figure.clr == Color.White) return;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveDown();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Down_1_Click(object sender, EventArgs e)
        {
            PPicture figure = (PPicture)comboBox1.SelectedItem;
            if (figure.clr == Color.White) return;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.EndDown();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Lefter_1_Click(object sender, EventArgs e)
        {
            PPicture figure = (PPicture)comboBox1.SelectedItem;
            if (figure.clr == Color.White) return;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.EndLeft();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Lefter_Click(object sender, EventArgs e)
        {
            PPicture figure = (PPicture)comboBox1.SelectedItem;
            if (figure.clr == Color.White) return;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveLeft();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Righter_Click(object sender, EventArgs e)
        {
            PPicture figure = (PPicture)comboBox1.SelectedItem;
            if (figure.clr == Color.White) return;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveRight();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Righter_1_Click(object sender, EventArgs e)
        {
            PPicture figure = (PPicture)comboBox1.SelectedItem;
            if (figure.clr == Color.White) return;
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.EndRight();
            figure.Show();
            figure.Draw(pictureBox1);
        }
    }

}

