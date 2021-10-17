using System;

namespace Task_02
{
    class Program
    {
        static bool Shift(ref char ch)
        {
            int x = (int)ch;
            Console.WriteLine(x);
            if ((x >= 97) && (x <= 122))
            {
                ch = (char)(96 + (((x - 96) + 4) % 26));
                Console.WriteLine(96 + (((x - 96) + 4) % 26));
                return true;
            } 
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            char ch;
            ConsoleKeyInfo keyInfo;
            do
            {
                do
                {
                    Console.Clear();
                    Console.Write("ch = ");
                } while (!char.TryParse(Console.ReadLine(), out ch));
                if (Shift(ref ch))
                {
                    Console.WriteLine("На 4 символа правее находится символ " + ch);
                }
                else { Console.WriteLine("Вы ввели не символ строчной латинской буквы"); }
                
                Console.WriteLine("\n\rДля выхода нажмите клавишу ESC");
                keyInfo = Console.ReadKey(true);
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
