using System;

namespace Task_02
{
    class Program
    {
        public static void Print(char[] mas)
        {
            foreach (var i in mas)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            Random random = new Random();
            char[] mas1 = new char[K];
            for (int i = 0; i < mas1.Length; i++)
                mas1[i] = (char)random.Next('A', 'Z' + 1);
            Print(mas1);

            char[] copy = new char[K];
            Array.Copy(mas1, copy, K);
            Array.Sort(copy);
            Print(copy);
            Array.Reverse(copy);
        }
    }
}
