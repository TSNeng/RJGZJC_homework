using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请按行以此输入每个矩阵");
            int[,] a = new int[2, 4] { { 12, 21, 41, 43,},{ 123, 124, 4543, 543 } };
            Console.WriteLine(Matrix_(a));
        }
        static bool Matrix_(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if (matrix[i,j] != matrix[i + 1,j + 1]) { return false; }
                }
            }
            return true;
        }
    }
}