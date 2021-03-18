using System;

namespace Lab_2_1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первая матрица с масивов строк");
            string[] temp = { "7 1 34", "78 98 54", "4 6 7" };
            MyMatrix mat = new MyMatrix(temp);
            Console.WriteLine(mat);

            Console.WriteLine("Вторая матрица с одной строчки");
            string temp2 = "17 567 98/77 88 55/17 22 71";
            MyMatrix mat2 = new MyMatrix(temp2);
            Console.WriteLine(mat2);

            Console.WriteLine("Сума двох матриць:");
            Console.WriteLine(mat + mat2);

            Console.WriteLine("Добуток двох матриць:");
            Console.WriteLine(mat * mat2);

            Console.WriteLine("Транспонована друга матриця:");
            Console.WriteLine(mat2.GetTransponedCopy());
        }
    }
}