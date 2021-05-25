using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_5
{
    public enum FigureType { Круг, Квадрат, Ромб }
    public partial class Form1 : Form
    {
       
        FigureType figure { get; set; }
        public Form1()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b; 
            comboBox1.Items.Add(FigureType.Круг);
            comboBox1.Items.Add(FigureType.Квадрат);
            comboBox1.Items.Add(FigureType.Ромб);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            figure = (FigureType)comboBox1.SelectedItem;
            Figure f;
            switch (figure)
            {
                case FigureType.Круг:
                    int radius = Convert.ToInt32(textBox1.Text);
                    f = new Circle(20, 200, radius);

                    Task task = new Task(() =>
                    {
                        while (true)
                        {
                            if (f.x >= 1000)
                            {

                                break;
                            }
                            f.MoveRight(pictureBox1);
                            Thread.Sleep(100);
                            this.Invoke(new MethodInvoker(delegate { pictureBox1.Refresh(); }));
                        }
                    });
                    task.Start();
                    break;



                case FigureType.Квадрат:
                    double sideLength = Convert.ToDouble(textBox2.Text);
                    f = new Square(20, 200, (int)sideLength);
                    Task task2 = new Task(() =>
                    {
                        while (true)
                        {
                            if (f.x >= 1000) break;
                            
                            f.MoveRight(pictureBox1);
                            Thread.Sleep(100);
                            this.Invoke(new MethodInvoker(delegate { pictureBox1.Refresh(); }));
                        }
                    });
                    task2.Start();
                    break;


                case FigureType.Ромб:
                    int horizontal = Convert.ToInt32(textBox3.Text);
                    int vertical = Convert.ToInt32(textBox4.Text);
                    f = new Rhomb(20, 200, horizontal, vertical);
                    Task task3 = new Task(() =>
                    {
                        while (true)
                        {
                            if (f.x >= 1000) break;
                            f.MoveRight(pictureBox1);
                            Thread.Sleep(100);
                            this.Invoke(new MethodInvoker(delegate { pictureBox1.Refresh(); }));
                        }
                    });
                    task3.Start();
                    break;
            }
        }
    }
}
