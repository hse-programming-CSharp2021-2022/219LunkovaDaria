using System;

namespace Task_06
{
    class Program
    {
        public static decimal Games(decimal B, int p)
        {
            return B * p / 100;
        }
        
        static void Main(string[] args)
        {
            decimal Budget;
            int p;
            string s;
            ConsoleKeyInfo keyInfo;
            do
            {
                do
                {
                    Console.Clear();
                    Console.Write("Введите бюджет пользователя: ");
                } while (!decimal.TryParse(Console.ReadLine(), out Budget));
                do
                {
                    Console.WriteLine("В какой валюте бюджет? \r\n" +
                        "Если рублях, введите: R\r\n" +
                        "В евро - E\r\n" + 
                        "В долларах - D");
                    s = Console.ReadLine().ToLower();
                } while (!((s == "r") || (s == "e") || (s == "d")));
                do
                {
                    Console.Write("Сколько процентов бюджета выделено на компьютерные игры? ");
                } while (!int.TryParse(Console.ReadLine(), out p));
                switch (s)
                {
                    case "r":
                        s = "RUB";
                        break;
                    case "e":
                        s = "EUR";
                        break;
                    case "d":
                        s = "USD";
                        break;
                }
                Console.WriteLine($"На игры выделено {Games(Budget, p)}{s}\r\n");
                Console.WriteLine("Для выхода нажмите клавишу ESC");
                keyInfo = Console.ReadKey(true);
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
