using System;

namespace Task_04
{
    class Program
    {
        public static string Reverse(int x)
        {
            char[] arr = x.ToString().ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
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
                    Console.Write("Введите четырёхзначное натуральное число: ");
                } while (!int.TryParse(Console.ReadLine(), out x) || (x < 1000) || (x > 9999));
                Console.WriteLine($"Его цифры в обратном порядке: {Reverse(x)}");
                Console.WriteLine("Для выхода нажмите клавишу ESC");
                keyInfo = Console.ReadKey(true);
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
