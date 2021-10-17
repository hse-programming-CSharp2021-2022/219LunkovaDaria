using System;

namespace Task_06
{
    class Program
    {
        static double S1(double x)
        {
            double summand = x * x;
            double res1, res2 = summand;
            int i = 3;
            do
            {
                res1 = res2;
                summand *= (-4) * x * x / (i * (i + 1));
                res2 += summand;
                i += 2;
            } while (res1 != res2);
            return res1;
        }
        static double S2(double x)
        {
            double summand = 1;
            double res1, res2 = summand;
            int i = 1;
            do
            {
                res1 = res2;
                summand *= (x / i);
                res2 += summand;
                i++;
            } while (res1 != res2);
            return res1;
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
                Console.WriteLine("S1 = " + S1(x));
                Console.WriteLine("S2 = " + S2(x));

                Console.WriteLine("\n\rДля выхода нажмите клавишу ESC");
                keyInfo = Console.ReadKey(true);
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
