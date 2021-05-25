using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;


namespace OOP_Lab_5
{
    abstract class Figure
    {
        public int x { get; set; }
        public int y { get; set; }

        public abstract void DrawBlack(PictureBox pictureBox);
        public abstract void HideDrawingBackGround(PictureBox pictureBox);
        public void MoveRight(PictureBox pictureBox)
        {
            HideDrawingBackGround(pictureBox);
            x += 5;
            DrawBlack(pictureBox);

        }
    }
}
