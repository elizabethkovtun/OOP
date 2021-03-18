using System;

namespace Lab_2_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Перший  дріб");
            MyFrac f1 = new MyFrac();
            Console.Write("Cкорочений дріб: ");
            MyFrac f11 = new MyFrac(f1.Nom, f1.Denom);
            MyFrac.ToStringWithIntegerPart(f1.Nom, f1.Denom);
            Console.WriteLine();
            Console.WriteLine("Другий дріб");
            MyFrac f2 = new MyFrac();
            Console.Write("Cкорочений дріб: ");
            MyFrac f22 = new MyFrac(f2.Nom, f2.Denom);
            MyFrac.ToStringWithIntegerPart(f2.Nom, f2.Denom);
            Console.WriteLine();

            Console.WriteLine("Результат додавання  двох дробів: ");
            MyFrac f3 = new MyFrac((f1.Nom * f2.Denom + f1.Denom * f2.Nom), (f1.Denom * f2.Denom));
            Console.WriteLine("Результат віднімання  двох дробів: ");
            MyFrac f4 = new MyFrac((f1.Nom * f2.Denom - f1.Denom * f2.Nom), (f1.Denom * f2.Denom));
            Console.WriteLine("Результат множення  двох дробів: ");
            MyFrac f5 = new MyFrac((f1.Nom * f2.Nom), (f1.Denom * f2.Denom));
            Console.WriteLine("Результат ділення  двох дробів: ");
            MyFrac f6 = new MyFrac((f1.Nom * f2.Denom), (f2.Nom * f1.Denom));
        }
    }
}