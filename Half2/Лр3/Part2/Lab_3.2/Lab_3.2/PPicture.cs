using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3._2
{
    class PPicture
    {
        string name { get; set; }
        int size { get; set; }

        int x { get; set; }
        int y { get; set; }
        Color color { get; set; }
        public Color clr { get; set; }

        Pen pen = new Pen(Color.Red);
        public PPicture(int x, int y, int size, string name, Color color)
        {
            this.size = size;
            this.name = name;
            this.x = x;
            this.y = y;
            this.color = color;
            clr = color;
        }
        public override string ToString() => name;

        public void Draw(PictureBox pictureBox)
        {
            pen.Color = clr;
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                g.DrawEllipse(pen, x, y, size, size);
                Point[] points1 = new Point[3];
                Point[] points2 = new Point[3];

                points1[0].X = x + size / 2; points1[0].Y = y;
                points1[1].X = x + size / 15; points1[1].Y = y + size / 4 * 3;
                points1[2].X = x + size - (size / 15); points1[2].Y = y + size / 4 * 3;
                points2[0].X = x + size / 2; points2[0].Y = y + size;
                points2[1].X = x + size / 15; points2[1].Y = y + size / 4;
                points2[2].X = x + size - (size / 15); points2[2].Y = y + size / 4;
                g.DrawPolygon(pen, points1);
                g.DrawPolygon(pen, points2);

                pictureBox.Refresh();
            }
        }
        public void MoveRight()
        {
            x++;
        }
        public void MoveLeft()
        {
            x--;
        }
        public void MoveUp()
        {
            y--;
        }
        public void MoveDown()
        {
            y++;
        }
        public void EndUp()
        {
            y = 0;
        }
        public void EndDown()
        {
            y = 455 - size;
        }
        public void EndLeft()
        {
            x = 0;
        }
        public void EndRight()
        {
            x = 623 - size;
        }
        public void Enlarge()
        {
            size++;
        }
        public void Reduce()
        {
            size--;
        }
        public void Hide()
        {
            clr = Color.White;
        }
        public void Show()
        {
            clr = color;
        }
    }
}

