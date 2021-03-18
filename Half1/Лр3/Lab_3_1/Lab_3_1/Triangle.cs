using System;
namespace Lab_3_1
{
    public class Triangle
    {
        private int ax;
        private int ay;
        private int bx;
        private int by;
        private int cx;
        private int cy;
        private int a;
        private int b;
        private int c;
        public Triangle()
        {
            Console.WriteLine("Введіть координати точки А:");
            Console.Write("X: ");
            ax = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            ay = int.Parse(Console.ReadLine());
            a =Math.Abs( ay - ax);
            Console.WriteLine("Size: "+a);
            Console.WriteLine("Введіть координати точки B:");
            Console.Write("X: ");
            bx = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            by = int.Parse(Console.ReadLine());
            b = Math.Abs(by - bx);
            Console.WriteLine("Size: " + b);
            Console.WriteLine("Введіть координати точки А:");
            Console.Write("X: ");
            cx = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            cy = int.Parse(Console.ReadLine());
            c = Math.Abs(ay - ax);
            Console.WriteLine("Size: " + c);
        }
        public int A
        {
            get
            {
                return a;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
        }
        public int C
        {
            get
            {
                return c;
            }
        }
        static bool CheckBeingTriangle(int a, int b, int c)
        {
            if (a + b > c && b + c > a && a + c > b)
            {
                return true;
            }
            else return false;
        }
        static void Perimetr(double a, double b, double c)
        {
            double perimetr = a + b + c;
            Console.WriteLine(perimetr);
        }
        static void Square(double a, double b, double c)
        {
            double square;
            double p = (a + b + c) / 2;
            square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine(square);
        }
        public static void Output(int a, int b, int c)
        {
            if(CheckBeingTriangle(a,b,c)==true)
            {
                Console.WriteLine("Трикутник існує");
                Perimetr(a, b, c);
                Square(a, b, c);
            }
            else Console.WriteLine("Такого трикутника не існує");
        }

    }
}
