using System;
using System.IO;
using System.Threading.Tasks;

namespace Lab_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string s2;
            int a;//перше число
            int b;//друге число
            int m;//добуток 
            long sum = 0;
            int n = 0;//кількість нормальних файлів
            for (int i = 10; i < 30; i++)
            {
                string path = @"Users\mac\Projects\Lab_4_1\Lab_4_1\txt" + i + ".txt";
                try
                {
                    StreamReader f = new StreamReader(path);
                    s1 = f.ReadLine();
                    a = Convert.ToInt32(s1);
                    s2 = f.ReadLine();
                    b = Convert.ToInt32(s2);
                    checked
                    {
                        m = a * b;
                    }
                    Console.WriteLine("Добуток чисел у файлі " + i + ".txt" + " становить: " + m);
                    sum += m;
                    n++;
                    f.Close();
                }
                catch (System.IO.FileNotFoundException)
                {
                    using (StreamWriter no_file = new StreamWriter(@"Users\mac\Projects\Lab_4_1\Lab_4_1\txt\no_file.txt", true, System.Text.Encoding.Default))
                    {
                        no_file.WriteLine(i + ".rtf");
                    }
                }
                catch (System.FormatException)
                {
                    using (StreamWriter bad_data = new StreamWriter(@"Users\mac\Projects\Lab_4_1\Lab_4_1\txt\bad_data.txt", true, System.Text.Encoding.Default))
                    {
                        bad_data.WriteLine(i + ".rtf");
                    }
                }
                catch (System.OverflowException)
                {
                    using (StreamWriter overflow = new StreamWriter(@"Users\mac\Projects\Lab_4_1\Lab_4_1\txt\overflow.txt", true, System.Text.Encoding.Default))
                    {
                        overflow.WriteLine(i + ".txt");
                    }
                }
                catch (System.IO.IOException)
                {
                    Console.WriteLine("Файл відсутній.");
                    break;
                }
            }
            Console.WriteLine("Кількість нормальних файлів - {0}. Середнє арифметичне добутку двох чисел з цих файлів - {1}", n, sum / n);

        }
    }
}