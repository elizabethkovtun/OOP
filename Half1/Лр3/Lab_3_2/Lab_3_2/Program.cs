using System;

namespace Lab_3_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TCircle circle1 = new TCircle();
            circle1.Output();
            TCircle circle2 = new TCircle();
            circle2.Output();

            TCircle sum = new TCircle(circle1.Radius + circle2.Radius);
            Console.WriteLine("Сума двох радіусів: " + sum);
            TCircle minus = new TCircle(Math.Abs(circle1.Radius - circle2.Radius));
            Console.WriteLine("Різниця двох радіусів: " + minus);
            int number = TCircle.Random();
            TCircle multiply = new TCircle(Math.Abs(circle1.Radius * number));
            Console.WriteLine("Множимо число на радіус: " + multiply);

            TCylinder cylinder1 = new TCylinder();
            double CSquare = cylinder1.Square();
            Console.WriteLine("Площа першого циліндра: " + CSquare);
            double volum = cylinder1.Volume();
            Console.WriteLine("Об'єм першого циліндра: " + volum);

            TCylinder cylinder2 = new TCylinder();
            CSquare = cylinder2.Square();
            Console.WriteLine("Площа другого циліндра: " + CSquare);
            volum = cylinder2.Volume();
            Console.WriteLine("Об'єм другого циліндра: " + volum);

        }
    }
}
