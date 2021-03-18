using System;
namespace Lab_3_2
{
    public class TCircle
    {
        private int radius;

        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                this.radius = value;
            }
        }
        public TCircle()
        {
            this.Radius = Random();
        }
        public TCircle(int radius)
        {
            this.Radius = radius;
        }
        public TCircle(TCircle circle)
        {
            this.Radius = circle.Radius;
        }
        public static int Random()
        {
            Random rand = new Random();
            int numb = rand.Next(1, 30);
            return numb;
        }
        private double GetLength()
        {
            return 2 * Math.PI * Radius;
        }
        private double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return Convert.ToString(this.Radius);
        }

        public static bool operator >(TCircle circle1, TCircle circle2)
        {
            return circle1.Radius > circle2.Radius;
        }
        public static bool operator <(TCircle circle1, TCircle circle2)
        {
            return circle1.Radius < circle2.Radius;
        }
        public static bool operator ==(TCircle circle1, TCircle circle2)
        {
            return circle1.Radius == circle2.Radius;
        }
        public static bool operator !=(TCircle circle1, TCircle circle2)
        {
            return circle1.Radius != circle2.Radius;
        }

        public static TCircle operator +(TCircle circle1, TCircle circle2)
        {
            return new TCircle(circle1.Radius + circle2.Radius);
        }
        public static TCircle operator -(TCircle circle1, TCircle circle2)
        {
            return new TCircle(Math.Abs(circle1.Radius - circle2.Radius));
        }
        public static TCircle operator *(TCircle circle1, int number)
        {
            return new TCircle(circle1.Radius * number);
        }
        public static TCircle operator *(int number, TCircle circle1)
        {
            return new TCircle(number * circle1.Radius);
        }
        public double GetSector(double a)
        {
            return Math.PI * Math.Pow(this.Radius, 2) * (a / 360);
        }
        public void Output()
        {
            double length = GetLength();
            Console.WriteLine("Радіус першого кола: " + Radius);
            Console.WriteLine("Довжина першого кола: " + length);
            double square = GetSquare();
            Console.WriteLine("Площа першого кола: " + square);
            int a = Random();
            double sector = GetSector(a);
            Console.WriteLine("Площа сектору з градусною мірою {0} дорівює {1} ", a, sector);
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || this.GetType() != obj.GetType())
            {
                return false;
            }
            TCircle temp = (TCircle)obj;
            return Radius == temp.Radius;
        }
        public override int GetHashCode()
        {
            return Radius.GetHashCode();
        }
    }
}