using System;
namespace OOP_Zalik_1
{
    public class Strings
    {
        private string a;
        public Strings()
        {
            a = "aBcDeFg";
        }
        public int Length(string s)
        {
            int leng = a.Length;
            return leng;

        }
        public string Sorting(string a)
        {
            string s = "";
            int leng = Length(a);
            string[] arr = new string[leng];

            for (int i = 0; i < leng; i++)
            {
                arr[i] = a.Split(' ')[i];
                Array.Sort(arr);
            }
            for (int i = 0; i < leng; i++)
            {
                s = arr[i] + " ";
            }
            return s;


        }
    }
    }