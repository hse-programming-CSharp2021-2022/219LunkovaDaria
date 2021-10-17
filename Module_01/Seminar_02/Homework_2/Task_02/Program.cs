using System;

namespace Task_02
{
    class Program
    {
        public static void MaxP(ref int x)
        {
            //char[] arr = x.ToString().ToCharArray();
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = x % 10;
                x /= 10;
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                x += arr[i] * (int)Math.Pow(10, 2 - i);
            }
        } 
        
        static void Main(string[] args)
        {
            int x;
            ConsoleKeyInfo keyInfo;
            do
            {
                do
                {
                    Console.Clear();
                    Console.Write("Введите трёхзначное натуральное число P: ");
                } while (!int.TryParse(Console.ReadLine(), out x) || (x < 100) || (x > 999));
                MaxP(ref x);
                Console.WriteLine($"Максимальное число, которое можно составить из цифр числа P: {x}");
                Console.WriteLine("Для выхода нажмите клавишу ESC");
                keyInfo = Console.ReadKey(true);
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
