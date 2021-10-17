using System;

namespace Task_02
{
    class Program
    {
        public static void func (float A, float delta)
        {
            double b = 0, sum = 0;
            do
            {
                sum += delta * (b * 2 + Math.Pow(b + delta, 2)) / 2;
                b += delta;
                if (b > A) { sum += (A - b) * (Math.Pow(b + delta, 2) + A * A) / 2; }
            } while (b <= A);
            
            Console.WriteLine(sum);
        }
        
        static void Main(string[] args)
        {
            float A = float.Parse(Console.ReadLine());
            float delta = float.Parse(Console.ReadLine());
            func(A, delta);
        }
    }
}
