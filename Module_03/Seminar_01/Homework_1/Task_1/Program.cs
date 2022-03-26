using System;

namespace Task_1
{
    //01_a #1
    class Program
    {
        public delegate int Cast(double x);
        static void Main(string[] args)
        {
            Cast anonim1 = delegate (double x)
            {
                Console.WriteLine((int)(x - (x % 2)));
                return (int)(x - (x % 2));
            };
            Cast anonim2 = delegate (double x)
            {
                int i = 0;
                while (x > 1)
                {
                    i++;
                    x /= 10;
                }
                Console.WriteLine(i - 1);
                return i - 1;
            };
            Cast del;
            del = anonim1;
            del += anonim2;
            Console.WriteLine("Введите вещественное число для проверки:");
            del(Double.Parse(Console.ReadLine()));
            Cast del2 = y => {
                Console.WriteLine((int)(y - (y % 2)));
                return (int)(y - (y % 2));
            };
            del2 += y =>
            {
                int i = 0;
                while (y > 1)
                {
                    i++;
                    y /= 10;
                }
                Console.WriteLine(i - 1);
                return i - 1;
            };
            Console.WriteLine("Введите вещественное число для проверки:");
            del2.Invoke(Double.Parse(Console.ReadLine()));
            del2 -= y => {
                Console.WriteLine((int)(y - (y % 2)));
                return (int)(y - (y % 2));
            };
            Console.WriteLine("Введите вещественное число для проверки:");
            del2.Invoke(Double.Parse(Console.ReadLine()));
            del2 -= anonim1;
            Console.WriteLine("Введите вещественное число для проверки:");
            del2.Invoke(Double.Parse(Console.ReadLine()));
        }
    }
}
