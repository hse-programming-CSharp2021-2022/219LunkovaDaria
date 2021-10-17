using System;

namespace Task_05
{
    class Program
    {
        public static void EqualSides (double a, double b, double c)
        {
            string s = ((a == b) && (a == c)) ? "Стороны равны" : "Треугольник не равносторонний";
            Console.WriteLine(s);
        }
        
        static void Main(string[] args)
        {
            double a, b, c;
            ConsoleKeyInfo keyInfo;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Введите длины сторон треугольника: ");
                } while (!double.TryParse(Console.ReadLine(), out a) ||
                        !double.TryParse(Console.ReadLine(), out b) ||
                        !double.TryParse(Console.ReadLine(), out c));
                EqualSides(a,b,c);
                Console.WriteLine("Для выхода нажмите клавишу ESC");
                keyInfo = Console.ReadKey(true);
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
