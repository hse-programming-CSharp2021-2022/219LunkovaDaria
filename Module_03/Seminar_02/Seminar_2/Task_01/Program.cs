using System;

namespace Task_01
{
    class Program
    {
        public static int d1(double x)
        {
            return (int)(x - x % 2);
        }

        public static int d2(double x)
        {
            return (int)(Math.Log10(x)) + 1;
        }

        public delegate int Cast(double x);
        static void Main(string[] args)
        {
            Cast anonim = delegate (double x)
            {
                return (int)(x - x % 2);
            };

            Cast lambda = (x) => (int)(Math.Log10(x)) + 1;
            double x = 0;
            for (var i = 0; i < 4; i++)
            {
                var rnd = new Random();
                x = (double)rnd.Next(100) / rnd.Next(10);
                Console.WriteLine($"x : {x}\n Anonim: {anonim(x)}\n Lamda: {lambda(x)}");
            }

            Console.WriteLine("x = " + x);
            Cast sum = anonim + lambda;
            Console.WriteLine(x + " " + sum?.Invoke(x));
            sum -= (x) => (int)(Math.Log10(x)) + 1;
            Console.WriteLine(x + " " + sum?.Invoke(x));

            Cast del1 = d1;
            Cast del2 = d2;
            Console.WriteLine(del1.Invoke(x));
            Console.WriteLine(del2.Invoke(x));
            Console.WriteLine();
            Cast del3 = del1 + del2;
            Console.WriteLine("del3 " + del3.Invoke(3));
            del3 -= d1;
            del3 -= d2;
            Console.WriteLine(del3?.Invoke(x));
        }
    }
}
