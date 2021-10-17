using System;

namespace Task_04
{
    class Program
    {
        static double Total(double k, double r, uint n)
        {
            if (n == 0) return k;
            return Total(k * (1 + r / 100), r, n - 1);
        }
        
        static void Main(string[] args)
        {
            double k = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            uint years = uint.Parse(Console.ReadLine());
            Console.WriteLine(Total(k, p, years));
        }
    }
}
