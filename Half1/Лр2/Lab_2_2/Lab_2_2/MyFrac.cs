using System;
namespace Lab_2_2
{
    public class MyFrac
    {
        private int nom;
        private int denom;

        public MyFrac()
        {
            Random rand = new Random();
            nom = rand.Next(1, 50);
            denom = rand.Next(1, 50);
            Console.WriteLine("Рандомно знаходимо дріб: {0}/{1}", nom, denom);
        }
        public MyFrac(int nom, int denom)
        {
            int CommonDenom = 1;
            if (denom < 0)
            {
                denom = -denom;
            }
            if (nom < 0)
            {
                nom = -nom;
            }
            for (int i = 2; i <= nom; i++)
            {
                if (denom % i == 0 && nom % i == 0)
                    CommonDenom = i;
            }

            nom = nom / CommonDenom;
            denom = denom / CommonDenom;
            Console.WriteLine(nom + "/" + denom);
        }

        public int Nom
        {
            get { return nom; }
        }
        public int Denom
        {
            get { return denom; }
        }
        public static void ToStringWithIntegerPart(int nom, int denom)
        {
            Console.WriteLine($"Дріб з виділеною цілою частиною: ({(nom) / (denom)}+{nom - (nom) / denom * denom}/{denom})");
        }
        public static void Plus(int nom1, int denom1, int nom2, int denom2)
        {
            Console.WriteLine("Результат додавання  двох дробів: " + (nom1 * denom2 + denom1 * nom2) + "/" + (denom1 * denom2));
        }
        public static void Minus(int nom1, int denom1, int nom2, int denom2)
        {
            Console.WriteLine("Результат віднімання двох дробів: " + (nom1 * denom2 - denom1 * nom2) + "/" + (denom1 * denom2));
        }
        public static void Multiply(int nom1, int denom1, int nom2, int denom2)
        {
            Console.WriteLine("Результат множення двох дробів: " + (nom1 * nom2) + "/" + (denom1 * denom2));
        }
        public static void Divide(int nom1, int denom1, int nom2, int denom2)
        {
            Console.WriteLine("Результат ділення двох дробів: " + (nom1 * denom2) + "/" + (denom1 * nom2));
        }
    }

}