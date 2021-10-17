using System;

namespace Task_02
{
    class Program
    {
        public static double F(double X, double Y)
        {
            if ((X < Y) && (X > 0)) { return X + Math.Sin(Y); }
            else if ((X > Y) && (X < 0)) { return Y - Math.Cos(X); }
            else { return 0.5 * X * Y; }
        }
        
        static void Main(string[] args)
        {
            double x, y;
            do
            {
                Console.Write("Введите X: ");
            } while (!double.TryParse(Console.ReadLine(), out x));
            do
            {
                Console.Write("Введите Y: ");
            } while (!double.TryParse(Console.ReadLine(), out y));

            Console.WriteLine("Значение функции G = F(X,Y) = " + F(x, y));
        }
    }
}
