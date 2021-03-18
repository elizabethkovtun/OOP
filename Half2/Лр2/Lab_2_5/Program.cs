using System;
using System.Reflection;

namespace Lab_2_5
{
    class MainClass
    {
        public  void Main(string[] args)
        {
            

            while(true)
            {
                try
                {
                    string st = Console.ReadLine();
                    int a = st[0];
                    int b = st[2];
                    string met = "Method" + st[0] ;
                    MethodInfo mi = this.GetType().GetMethod(met);
                    mi.Invoke(this, b);
                  
                }
                catch
                {
                    Console.WriteLine("Неправильний формат введення");
                    break;
                }

              
            }

        }

        public static double Method0(int n) => Math.Sqrt(n);
        public static double Method1(int n) => n * n * n;
        public static double Method2(int n)=> n+3.5;

    }
}
