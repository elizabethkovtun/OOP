using System;

namespace Lab_1_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Write how many  rows: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Columns: ");
            int column = int.Parse(Console.ReadLine());
            int[,] matrixA = new int[row, column];
            int[][] matrixB = new int[row][];
            Console.WriteLine("Your random matrix A: ");
            RandMatrix(row, column, matrixA);
            FindNumbInRow(matrixA, matrixB, row, column);
            NullMatrixB(matrixB, row);
            Console.WriteLine("Matrix B: ");
            MatrixB(matrixA, matrixB, row, column);
        }
        public static void RandMatrix(int row, int column, int[,] matrixA)
        {
            Random rand = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrixA[i, j] = rand.Next(-20, 20);
                    Console.Write(matrixA[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int Find_Min(int[,] matrixA, int numbrow, int column)
        {
            int min = 0;
            if (matrixA[numbrow, column - 1] < matrixA[numbrow, 0])
            {
                min = matrixA[numbrow, column - 1];
            }
            else if (matrixA[numbrow, column - 1] > matrixA[numbrow, 0])
            {
                min = matrixA[numbrow, 0];
            }
            return min;
        }
        public static int Find_Max(int[,] matrixA, int numbrow, int column)
        {
            int max = 0;
            if (matrixA[numbrow, column - 1] >= matrixA[numbrow, 0])
            {
                max = matrixA[numbrow, column - 1];
            }
            else if (matrixA[numbrow, column - 1] <= matrixA[numbrow, 0])
            {
                max = matrixA[numbrow, 0];
            }
            return max;
        }
        public static void FindNumbInRow(int[,] matrixA, int[][] matrixB, int row, int column)
        {
            for (int i = 0; i < row; i++)
            {
                int max = Find_Max(matrixA, i, column);
                int min = Find_Min(matrixA, i, column);
                int count = 0;
                for (int j = 0; j < column; j++)
                {
                    if ((matrixA[i, j] >= min && matrixA[i, j] <= max))
                    {
                        count++;
                    }
                }
                matrixB[i] = new int[count];
            }
        }
        public static void NullMatrixB(int[][] matrix, int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = 0;
                }
            }
        }
        public static void MatrixB(int[,] matrixA, int[][] matrixB, int row, int column)
        {
            for (int i = 0; i < row; i++)
            {
                int max = Find_Max(matrixA, i, column);
                int min = Find_Min(matrixA, i, column);
                int ij = 0;
                for (int j = 0; j < column; j++)
                {
                    if (matrixA[i, j] >= min && matrixA[i, j] <= max)
                    {
                        matrixB[i][ij] = matrixA[i, j];
                        Console.Write(matrixB[i][ij] + " ");
                        ij++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
