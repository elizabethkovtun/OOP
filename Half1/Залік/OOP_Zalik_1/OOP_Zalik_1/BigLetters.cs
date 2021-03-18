using System;
namespace OOP_Zalik_1
{
    public class BigLetters : Strings
    {
        private string b;
        public BigLetters()
        {
            b = "G H K R T";
        }
        public BigLetters(string B)
        {
            B = b;
        }
        public static void Output()
        {
            Console.WriteLine("Довижна рядка {0}", Length(b));
            Console.WriteLine("Відсортований рядок {0}", Sorting(b));
        }

    }
}