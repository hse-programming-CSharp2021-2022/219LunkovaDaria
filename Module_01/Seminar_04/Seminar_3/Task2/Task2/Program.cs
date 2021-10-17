using System;

namespace Task2
{
    class Program
    {
        public static bool Function1 (bool p, bool q)
        {
            return (!(p && q) & !(p || !q));
        }

        public static void Function2 (out bool res, bool p, bool q)
        {
            res = !(p && q) & !(p || !q);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("p q      !(p & q) & !(p | !q)");
            Console.WriteLine("0 0      " + Function1(false, false));
            Console.WriteLine("0 1      " + Function1(false, true));
            Console.WriteLine("1 0      " + Function1(true, false));
            Console.WriteLine("1 1      " + Function1(true, true) + "\r\n");

            Console.WriteLine("p q      !(p & q) & !(p | !q)");
            bool res;
            Function2(out res, false, false);
            Console.WriteLine("0 0      " + res);
            Function2(out res, false, true);
            Console.WriteLine("0 1      " + res);
            Function2(out res, true, false);
            Console.WriteLine("1 0      " + res);
            Function2(out res, true, true);
            Console.WriteLine("1 1      " + res);
        }
    }

    //оформить как таблицу истинности
}
