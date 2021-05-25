using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_5
{
    class Circle : Figure
    {
        int radius { get; set; }
        public Circle()
        { }
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public Circle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Circle(int x, int y, int radius)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }
        public override void DrawBlack(PictureBox pictureBox)
        {
            var g = Graphics.FromImage(pictureBox.Image);
            g.DrawEllipse(Pens.Black, x, y, radius, radius);
            
        }
        public override void HideDrawingBackGround(PictureBox pictureBox)
        {
            var g = Graphics.FromImage(pictureBox.Image);
            g.DrawEllipse(Pens.White, x, y, radius, radius);
            

        }
    }
}
