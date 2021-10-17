using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas1 = new int[100];
            Random random = new Random();

            for (int i = 0; i < mas1.Length; i++)
                mas1[i] = i + 1;
            for (int i = mas1.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var x = mas1[j];
                mas1[j] = mas1[i];
                mas1[i] = x;
            }

            Array.Resize(ref mas1, 99);

            int sum = 0;
            for (int i = 0; i < mas1.Length; i++)
            {
                sum += mas1[i];
            }
            Console.WriteLine(5050 - sum);
        }
    }
}
