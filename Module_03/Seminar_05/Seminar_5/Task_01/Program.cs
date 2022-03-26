﻿using System;

namespace Task_01
{
    interface IFunction
    {
        double Function(double x);
    }

    public delegate double calculate(double x);

    class F : IFunction
    {
        calculate calc;
        public F(calculate c) => calc = c;
        public double Function(double x)
        {
            return calc(x);
        }
    }
    class G
    {
        F func1;
        F func2;
        public G(F f1, F f2)
        {
            func1 = f1;
            func2 = f2;
        }
        public double GF(double x0)
        {
            return func1.Function(func2.Function(x0));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            G g = new G(new F(x => x * x - 4), new F(x => Math.Sin(x)));

            for (double i = 0; i < Math.PI; i += Math.PI / 16)
            {
                Console.WriteLine($"{g.GF(i):F4}");
            }
        }
    }
}
