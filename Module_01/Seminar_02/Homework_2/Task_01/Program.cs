using System;

namespace Task_01
{
    class Program
    {
        public static void Polynomial(int x)
        {
            Console.WriteLine(x * (x * (x * (x + x + x + x + x + x + x + x + x + x + x + x + 9) - 3) + 2) - 4);
        }
        
        static void Main(string[] args)
        {
            int x;
            ConsoleKeyInfo keyInfo;
            do
            {
                do
                {
                    Console.Clear();
                    Console.Write("x = ");
                } while (!int.TryParse(Console.ReadLine(), out x));
                Polynomial(x);
                Console.WriteLine("Для выхода нажмите клавишу ESC");
                keyInfo = Console.ReadKey(true);
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
