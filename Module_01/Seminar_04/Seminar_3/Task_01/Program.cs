using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum1 = 0, sum2 = 0;
            int n = 1;
            bool ok = true;
            do
            {
                sum2 += (1.0f / (n * (n + 1) * (n + 2)));
                if (sum2 != sum1) { sum1 = sum2; }
                else { ok = false; }
            } while (ok == true);
            Console.WriteLine("Float result: " + sum2);

            double sum3 = 0, sum4 = 0;
            n = 1;
            ok = true;
            do
            {
                sum4 += (1.0f / (n * (n + 1) * (n + 2)));
                if (sum4 != sum3) { sum3 = sum4; }
                else { ok = false; }
            } while (ok == true);
            Console.WriteLine("Double result: " + sum4);

        }
    }
}
