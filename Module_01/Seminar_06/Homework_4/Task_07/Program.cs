using System;

namespace Task_07
{
    class Program
    {
        static void Function(out uint GCD, out uint LCM, uint A, uint B)
        {
            GCD = 0;
            uint A1 = A, B1 = B;
            do
            {
                if (A == B)
                {
                    GCD = A;
                }
                else if (A > B)
                {
                    A -= B;
                }
                else
                {
                    B -= A;
                }
            } while (GCD == 0);
            LCM = A1 * B1 / GCD;
        }
        static void Main(string[] args)
        {
            uint A, B;
            ConsoleKeyInfo keyInfo;
            do
            {
                do
                {
                    Console.Clear();
                    Console.Write("A = ");
                } while (!uint.TryParse(Console.ReadLine(), out A));
                do
                {
                    Console.Clear();
                    Console.Write("A = " + A + "\n\rB = ");
                } while (!uint.TryParse(Console.ReadLine(), out B));
                Function(out uint GCD, out uint LCM, A, B);
                Console.WriteLine($"НОД({A},{B}) = {GCD}\n\rНОК({A},{B}) = {LCM}");

                Console.WriteLine("\n\rДля выхода нажмите клавишу ESC");
                keyInfo = Console.ReadKey(true);
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
