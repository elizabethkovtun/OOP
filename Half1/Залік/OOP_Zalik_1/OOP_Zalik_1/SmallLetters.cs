using System;
namespace OOP_Zalik_1
{
    public class SmallLatters : Strings
    {
        private string c;
        public SmallLatters()
        {
            c = "gsjuncy";
        }
        public SmallLatters(string C)
        {
            C = c;
        }

        string Sorting()
        {
            string s = "";
            int leng = Length(c);
            string[] arr = new string[leng];
            string[] arr1 = new string[leng];

            for (int i = 0; i < leng; i++)
            {
                arr[i] = c.Split(' ')[i];
                Array.Sort(arr);
            }
            for (int i = leng; i >= 0; i--)
            {
                for (int j = 0; j < leng; j++)
                {
                    arr1[j] = arr[i];
                }
            }
            for (int i = 0; i < leng; i++)
            {
                s = arr[i] + " ";
            }
            return s;


        }
        public static void Output()
        {
            Console.WriteLine("Довижна рядка {0}", Length(c));
            Console.WriteLine("Відсортований рядок {0}", Sorting());
        }
    }
}