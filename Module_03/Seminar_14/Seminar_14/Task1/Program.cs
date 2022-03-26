using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<int>();
            Random rnd = new();
            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(-10000, 10001));
            }
            list.ForEach(g => Console.WriteLine(g));
            Console.WriteLine();

            var z1_1 = from g in list
                       select (Math.Abs(g) % 10);
            var z1_2 = list.Select(g => Math.Abs(g) % 10);

            var z2_1 = from g in list
                       group g by (Math.Abs(g) % 10) into newList
                       select newList;
            var z2_2 = list.GroupBy(g => Math.Abs(g) % 10);

            var z3_1 = from g in list
                       where (g > 0 && g % 2 == 0)
                       select g;
            var z3_2 = list.Where(g => g > 0 && g % 2 == 0);

            var z4_1 = (from g in list
                       where g % 2 == 0
                       select g).Sum();
            var z4_2 = list.Where(g => g % 2 == 0).Sum();

            var z5_1 = from g in list
                       orderby (Math.Abs(g).ToString()[0] - 48, Math.Abs(g) % 10)
                       select g;
            var z5_2 = list.OrderBy(g => (int)(Math.Abs(g).ToString()[0]))
                .ThenBy(g => Math.Abs(g) % 10);

            foreach (var item in z1_1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (var item in z1_2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (var item in z2_1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in z2_2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(z3_1.Count());
            foreach (var item in z3_1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in z3_2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\n{0}, {1}\n",z4_1, z4_2);
            foreach (var item in z5_1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in z5_2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
