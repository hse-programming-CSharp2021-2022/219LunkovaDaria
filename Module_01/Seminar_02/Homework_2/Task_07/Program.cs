using System;

namespace Task_07
{
    class Program
    {
        public static void F1(double x)
        {
            Console.WriteLine($"Целая часть: {Math.Floor(x)} \r\n" +
                    $"Дробная часть числа: {x - Math.Floor(x)}");
        }
        public static void F2(double x)
        {
            Console.WriteLine("Квадрат числа: " + x * x);
            if (x < 0) { Console.WriteLine("Число отрицательное, нельзя извлечь вещественный корень"); }
            else { Console.WriteLine("Корень: " + Math.Sqrt(x)); }
        }
        static void Main(string[] args)
        {
            double x;
            ConsoleKeyInfo keyInfo;
            do
            {
                do
                {
                    Console.Clear();
                    Console.Write("x = ");
                } while (!double.TryParse(Console.ReadLine(), out x));
                F1(x);
                F2(x);
                Console.WriteLine("\n\rДля выхода нажмите клавишу ESC");
                keyInfo = Console.ReadKey(true);
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
