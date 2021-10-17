using System;

namespace Task_03
{
    class Program
    {
        public static double F(double X)
        {
            if (X <= 0.5) { return Math.Sin(Math.PI * 0.5); }
            else { return Math.Sin(Math.PI * 0.5 * (X -1)); }
        }
        static void Main(string[] args)
        {
            double x;
            do
            {
                Console.Write("Введите X: ");
            } while (!double.TryParse(Console.ReadLine(), out x));
            
            Console.WriteLine("Значение функции G = F(X) = " + F(x));
        }
    }
}
