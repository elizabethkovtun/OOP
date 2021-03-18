using System;

namespace Lab_1_2
{
    
    class MainClass
    {
        public static void Main(string[] args)
        {
            TTriangle tr = new TTriangle();
            TTriangle.Tr(tr.A, tr.B, tr.C);

            Console.Write("Changed side A:  ");
            tr.A = double.Parse(Console.ReadLine());
            TTriangle.Tr(tr.A, tr.B, tr.C);

            Console.Write("Changed side B:  ");
            tr.B = double.Parse(Console.ReadLine());
            TTriangle.Tr(tr.A, tr.B, tr.C);

            Console.Write("Changed side C:  ");
            tr.C = double.Parse(Console.ReadLine());
            TTriangle.Tr(tr.A, tr.B, tr.C);
        }
    }
}
