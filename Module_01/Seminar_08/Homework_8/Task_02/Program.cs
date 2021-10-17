using System;

namespace Task_02
{
    class Program
    {
        public static int[,] SnailMatrix(int n)
        {
            int[,] arr = new int[n, n];
            int offset = 0, row, col, num;
            for (num = 1; num <= n * n; offset++)
            {
                for (row = offset; row < n - offset; row++, num++)
                {
                    col = offset;
                    arr[row, col] = num;
                }
                for (col = offset + 1; col < n - offset; col++, num++)
                {
                    row = n - offset - 1;
                    arr[row, col] = num;
                }
                for (row = n - offset - 2; row >= offset; row--, num++)
                {
                    col = n - offset - 1;
                    arr[row, col] = num;
                }
                for (col = n - offset - 2; col >= offset + 1; col--, num++)
                {
                    row = offset;
                    arr[row, col] = num;
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[,] arr = SnailMatrix(8);
            for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j],4}");
                }
            }
        }
    }
}
