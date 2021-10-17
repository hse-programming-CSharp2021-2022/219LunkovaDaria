using System;

namespace Task_03
{
    class Program
    {
        public static string Function(double A, double B, double C)
        {
            double d = B * B - 4 * A * C;
            return d > 0 ? 
                $"Первый корень: {(-B + Math.Sqrt(d)) / (2 * A)},\r\n" +  //при D > 0 корней два
                $"Второй корень: {(-B - Math.Sqrt(d)) / (2 * A)}" :
                (d == 0 ?   //при D = 0 корень один
                $"Единственный корень равен: {-B / 2}" :
                "Вещественных корней нет"); //при D < 0 вещ. корней нет
        }
        static void Main(string[] args)
        {
            double A, B, C;
            ConsoleKeyInfo keyInfo;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Введите значения коэффициентов A, B, C: ");
                } while (!double.TryParse(Console.ReadLine(), out A) || 
                (!double.TryParse(Console.ReadLine(), out B)) || 
                (!double.TryParse(Console.ReadLine(), out C)));
                Console.WriteLine(Function(A, B, C));
                Console.WriteLine("Для выхода нажмите клавишу ESC");
                keyInfo = Console.ReadKey(true);
            } while (keyInfo.Key != ConsoleKey.Escape);

        }
    }
}
