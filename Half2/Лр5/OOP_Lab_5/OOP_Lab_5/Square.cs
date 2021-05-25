using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_5
{
    class Square : Figure
    {
        int side { get; set; }
        public Square() 
        { }
        public Square(int sideLength)
        {
            this.side = sideLength; 
        }
        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Square(int x, int y, int side)
        {
            this.side = side;
            this.x = x;
            this.y = y;
        }
        public override void DrawBlack(PictureBox pictureBox)
        {
            Pen pen = Pens.Black;
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                g.DrawRectangle(pen, x, y, side, side);
            }

        }
        public override void HideDrawingBackGround(PictureBox pictureBox)
        {
            Pen c = Pens.White;
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                g.DrawRectangle(c, x, y, side, side);
            }

        }
    }
}