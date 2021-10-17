using System;

namespace noTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            switch(a)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                default:
                    Console.WriteLine("noone");
                    break;
            }
        }
    }
}
