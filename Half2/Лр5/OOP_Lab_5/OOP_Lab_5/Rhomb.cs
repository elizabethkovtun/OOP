using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_5
{
    class Rhomb : Figure
    {
        int horDiag { get; set; }

        int vertDiag { get; set; }

        public Rhomb() 
        { }
        public Rhomb(int horDiagLen, int vertDiagLen)
        {
            this.horDiag = horDiagLen;
            this.vertDiag = vertDiagLen;
        }
        public Rhomb(int x, int y, int horDiagLen, int vertDiagLen)
        {
            this.x = x;
            this.y = y;
            this.horDiag = horDiagLen;
            this.vertDiag = vertDiagLen;
        }

        public override void DrawBlack(PictureBox pictureBox)
        {

            Pen pen = Pens.Black;
            var g = Graphics.FromImage(pictureBox.Image);
            Rectangle rectangle = new Rectangle(x, y, (int)horDiag, (int)vertDiag);
            Matrix matrix = new Matrix();
                
                    matrix.RotateAt(45, new PointF(rectangle.Left + (rectangle.Width / 2), rectangle.Top + (rectangle.Height / 2)));

                    g.Transform = matrix;
                    g.DrawRectangle(pen, rectangle);

                


            }
        
        public override void HideDrawingBackGround(PictureBox pictureBox)
        {

            Pen pen = Pens.White;
            var g = Graphics.FromImage(pictureBox.Image);
            Rectangle rectangle = new Rectangle(x, y, (int)horDiag, (int)vertDiag);
            Matrix matrix = new Matrix();
            matrix.RotateAt(45, new PointF(rectangle.Left + (rectangle.Width / 2),rectangle.Top + (rectangle.Height / 2)));
            g.Transform = matrix;
            g.DrawRectangle(pen, rectangle);
            
            
        }
        
    }
}
