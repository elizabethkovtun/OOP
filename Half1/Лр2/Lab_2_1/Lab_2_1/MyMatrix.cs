using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_2_1
{
    public class MyMatrix
    {
        private double[,] matrix;

        public double this[int i, int j]
        {
            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }
        public MyMatrix(double[,] matriX)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    matriX[i, j] = matrix[i, j];
                }
            }
        }
        public MyMatrix()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    matrix[i, j] = 1;
                }
            }
        }
        public MyMatrix(double[][] mat)
        {
            bool a = true;
            for (int i = 1; a == true && i < mat.Length; i++)
            {
                for (int j = 0; a == true && j < mat[i].Length; j++)
                {
                    if (mat[i].Length != mat[0].Length)
                    {
                        a = false;
                    }
                    this.matrix[i, j] = mat[i][j];
                }
            }
        }
        public MyMatrix(string[] mat)
        {
            int[] temp;
            double[,] temp2 = new double[mat.Length, mat.Length];
            for (int i = 0; i < mat.Length; i++)
            {
                temp = mat[i].Split().Select(int.Parse).ToArray();
                for (int j = 0; j < temp.Length; j++)
                {
                    temp2[i, j] = temp[j];
                }
            }
            matrix = temp2;
        }
        public MyMatrix(string ma)
        {
            string[] temp1 = ma.Split('/');
            int[] temp;
            double[,] output = new double[temp1.Length, temp1.Length];
            for (int i = 0; i < temp1.Length; i++)
            {
                temp = temp1[i].Split().Select(int.Parse).ToArray();
                for (int j = 0; j < temp.Length; j++)
                {
                    output[i, j] = temp[j];
                }
            }
            matrix = output;
        }
        public int GetHeight()
        {
            return Height();
        }
        public int GetWidth()
        {
            return Width();
        }
        private int Height()
        {
            return matrix.GetLength(0);
        }
        private int Width()
        {
            return matrix.GetLength(1);
        }
        public static MyMatrix operator +(MyMatrix matrix1, MyMatrix matrix2)
        {
            double[,] result = new double[matrix1.Height(), matrix2.Width()];
            for (int i = 0; i < matrix1.Height(); i++)
            {
                for (int j = 0; j < matrix2.Width(); j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return new MyMatrix(result);
        }
        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
        {
            double[,] result = new double[matrix1.Height(), matrix2.Width()];
            for (int i = 0; i < matrix1.Height(); i++)
            {
                for (int j = 0; j < matrix2.Width(); j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < matrix1.Width(); k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return new MyMatrix(result);
        }
        protected double[,] GetTransponedArray()
        {
            double[,] result = new double[Width(), Height()];

            for (int i = 0; i < Width(); i++)
            {
                for (int j = 0; j < Height(); j++) result[i, j] = this.matrix[j, i];
            }

            return result;
        }
        public MyMatrix GetTransponedCopy()
        {
            MyMatrix result = new MyMatrix(GetTransponedArray());
            return result;
        }

    }
}