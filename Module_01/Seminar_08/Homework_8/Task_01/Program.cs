using System;

namespace Task_01
{
    class Program
    {
        public static int[,] SnakeMatrix(int row, int col)
        {
            int[,] arr = new int[row, col];
            for (int i = 0; i < row; i++, Console.WriteLine())
            {

                for (int j = 0; j < col; j++)
                {
                    if (i % 2 == 0)
                    {
                        arr[i, j] = i * col + j + 1;
                    }
                    else
                    {
                        arr[i, j] = (i + 1) * col - j;
                    }
                    Console.Write($"{arr[i, j],4}");
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {
            SnakeMatrix(10,10);
        }
    }
}
