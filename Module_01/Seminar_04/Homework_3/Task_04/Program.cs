using System;

namespace Task_04
{
    class Program
    {
        public static void Input(int n, out int x)  // Ввод номера аудитории
        {
            do
            {
                Console.WriteLine($"Введите номер {n} аудитории: ");
            } while (!int.TryParse(Console.ReadLine(), out x) || (x < 100) || (x > 999));
        }
        public static int F(int a, int b, int c)    // Поиск нужной аудитории среди трёх
        {
            if ((a % 100 <= b % 100) && (a % 100 <= c % 100)) { return a; }
            else if (b % 100 <= c % 100) { return b; }
            else { return c; }           
        }

        static void Main(string[] args)
        {
            int a, b, c;
            Input(1, out a);
            Input(2, out b);
            Input(3, out c);
            Console.WriteLine("Аудитория с мин. номером внутри этажа: " + F(a, b, c));
        }
    }
}
