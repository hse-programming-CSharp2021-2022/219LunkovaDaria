using System;

namespace Task_01
{
    class Program
    {
        static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0;
            sumOdd = 0;
            for (int i = 0; number > 0; ++i, number /= 10)
            {
                if (i % 2 == 0) { sumEven += number % 10; }
                else { sumOdd += number % 10; }
            }
        }
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            Sums(number, out uint sumEven, out uint sumOdd);
            Console.WriteLine(sumEven + " " + sumOdd);
        }
    }
}
