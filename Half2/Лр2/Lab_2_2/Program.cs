using System;
using System.Threading;

namespace Lab_2_2
{
    delegate void Methods();
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість секунд: ");
            int seconds = int.Parse(Console.ReadLine());
            Method timer = new Method(seconds);
            timer.Start();
        }
    }
}