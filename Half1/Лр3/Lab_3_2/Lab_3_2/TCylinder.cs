using System;
namespace Lab_3_2
{
    class TCylinder : TCircle
    {
        private int height;

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                this.height = value;
            }
        }

        public TCylinder() : base()
        {
            Height = TCircle.Random();

        }
        public TCylinder(int Height)
        {
            height = Height;
        }

        public TCylinder(int radius, int height) : base(radius)
        {
            this.Height = Height;
        }

        public override string ToString()
        {
            return Convert.ToString(Height);
        }

        public TCylinder(TCircle circle, double height) : base(circle)
        {
            this.Height = Height;
        }

        public static bool operator >(TCylinder cylinder1, TCylinder cylinder2)
        {
            return cylinder1.Volume() > cylinder2.Volume();
        }
        public static bool operator <(TCylinder cylinder1, TCylinder cylinder2)
        {
            return cylinder1.Volume() < cylinder2.Volume();
        }

        public static bool operator ==(TCylinder cylinder1, TCylinder cylinder2)
        {
            return cylinder1.Volume() == cylinder2.Volume();
        }
        public static bool operator !=(TCylinder cylinder1, TCylinder cylinder2)
        {
            return cylinder1.Volume() != cylinder2.Volume();
        }


        public double Volume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }

        public double Square()
        {
            return 2 * Math.PI * Radius * (Height * Radius);
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || this.GetType() != obj.GetType())
            {
                return false;
            }
            TCylinder temp = (TCylinder)obj;
            return Volume() == temp.Volume();
        }

        public override int GetHashCode()
        {
            return Volume().GetHashCode();
        }
    }
}