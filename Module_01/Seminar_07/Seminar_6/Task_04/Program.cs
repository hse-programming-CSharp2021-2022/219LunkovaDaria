using System;

namespace Task_04
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
            //Дан массив из 100 элементов от 1 до 100, какой-то элемент повторяется дважды,
            //а какого-то нет. Найти элемент, который повторяется дважды.
            //3 и 8 из презы.
            for (int i = 0; i < mas1.Length; i++)
            {

            }

            int sum = 0;
            for (int i = 0; i < mas1.Length; i++)
            {
                sum += mas1[i];
            }
            Console.WriteLine(5050 - sum);
        }
    }
}
