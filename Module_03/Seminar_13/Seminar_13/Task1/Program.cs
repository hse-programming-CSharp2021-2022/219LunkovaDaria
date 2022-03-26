using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibbonachi fibbonachi = new();
            foreach (var elem in fibbonachi)
            {
                Console.WriteLine(elem);
            }
             foreach (var a in fibbonachi.NextElementYield(15))
            {
                Console.WriteLine(a);
            }
        }
    }


    class Fibbonachi
    {
        int a0 = 0, a1 = 1;
        public IEnumerable NextElementYield(int n)
        {
            int current = a0;
            int next = a1;
            for (int i = 0; i < n; i++)
            {
                yield return next;
                (current, next) = (next, current + next);
            }
        }
        public IEnumerator GetEnumerator()
        {
            int current = a0;
            int next = a1;
            for (int i = 0; i < 5; i++)
            {
                yield return next;
                (current, next) = (next, current + next);
            }
        }
    }
}