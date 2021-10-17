using System;

namespace Task3
{
    class Program
    {
        public static void Func1()  //цикл for
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i * i + " ");
            }
        }

        public static void Func2()  //цикл do..while
        {
            int x = 1;
            do
            {
                Console.Write(x * x + " ");
                x++;
            } while (x <= 10);
        }

        public static void Func3()  //цикл while..
        {
            int x = 1;
            while (x <= 10)
            {
                Console.Write(x * x + " ");
                x++;
            }
        }


        static void Main(string[] args)
        {
            Console.Write("цикл for: ");
            Func1();
            Console.Write("\r\nцикл do..while: ");
            Func2();
            Console.Write("\r\nцикл while..: ");
            Func3();
        }
    }
}
