using System;
using System.Threading;

namespace Lab_2_2
{
    class Method
    {
        private int seconds { get; set; }
        public Method(int _seconds)
        {
            this.seconds = _seconds;
        }
        public void Start()
        {
            Methods[] time = new Methods[] { Method1, Method2, Method3, Method4 };
            Random rand = new Random();
            while (true)
            {
                Thread.Sleep(seconds * 1000);
                int a = rand.Next(0, 4);
                time[a]();
            }
        }
        private static void Method1() => Console.WriteLine("Був виконаний метод номер 1");
        private static void Method2() => Console.WriteLine("Був виконаний метод номер 2");
        private static void Method3() => Console.WriteLine("Був виконаний метод номер 3");
        private static void Method4() => Console.WriteLine("Був виконаний метод номер 4");
    }
}
