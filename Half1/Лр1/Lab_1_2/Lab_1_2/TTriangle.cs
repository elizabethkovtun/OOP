using System;
namespace Lab_1_2
{
    class TTriangle
    {

        protected double a;
        protected double b;
        protected double c;
        public TTriangle()
        {
            Random rand = new Random();
            while (a + b <= c || a + c <= b || b + c <= a)
            {
                this.a = rand.Next(1, 100);
                this.b = rand.Next(1, 100);
                this.c = rand.Next(1, 100);
            }
        }
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                value = double.Parse(Console.ReadLine());
                if (value + b <= c || value + c <= b || value >= b + c)
                {
                    while (value + b <= c || value + c <= b || value >= b + c)
                    {
                        value = double.Parse(Console.ReadLine());
                    }
                }
                a = value;
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                value = double.Parse(Console.ReadLine());
                if (value + a < c || a + c < value || a > value + c)
                {
                    while (value + a < c || a + c < value || a > value + c)
                    {
                        value = double.Parse(Console.ReadLine());
                    }
                }
                b = value;
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                value = double.Parse(Console.ReadLine());
                if (a + b < value || a + value < b || value > b + a)
                {
                    while (a + b < value || a + value < b || value > b + a)
                    {
                        value = double.Parse(Console.ReadLine());
                    }
                }
                c = value;
            }
        }
        static double Perimetr(double a, double b, double c)
        {
            double perimetr = a + b + c;
            return perimetr;
        }
        static double Square(double a, double b, double c)
        {
            double square;
            double semiper = (a + b + c) / 2;
            square = Math.Sqrt(semiper * (semiper - a) * (semiper - b) * (semiper - c));
            return square;
        }
        public static void Tr(double a, double b, double c)
        {
            double perimetr = Perimetr(a, b, c);
            double square = Square(a, b, c);

            Console.WriteLine("Side A: {0}   Side B: {1}   Side B: {2}", a, b, c);

            Console.Write("Perimetr: {0}   ", perimetr);
            Console.WriteLine("Square: {0}   ", square);
        }
    }
}
