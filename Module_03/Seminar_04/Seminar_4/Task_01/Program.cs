using System;

namespace Task_01
{

    public delegate void NewStringValue(string s);
    public class UIString
    {
        string str = "Default text";
        public string Str { get { return str; } private set { str = value; } }
        public void NewStringValueHappenedHandler(string s)
        {
            str = s;
        }
    }
    class ConsoleUI
    {
        UIString s = new UIString(); // специальная строка
        public UIString S { get { return s; } set { s = value; } }
        public event NewStringValue NewStringvalueHappend;
        public void GetStringFromUI()
        {
            Console.Write("Введите новое значение строки: ");
            string str = Console.ReadLine();
            NewStringvalueHappend(str);
            RefreshUI();
        }
        public void CreateUI()
        {
            NewStringvalueHappend += S.NewStringValueHappenedHandler;
            RefreshUI();
        }
        public void RefreshUI()
        {      // обновление строки     
            Console.Clear();
            Console.WriteLine("Текст строки: " + s.Str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI c = new ConsoleUI();
            c.CreateUI(); // запускаем выполнение объекта класса ConsoleUI
            do
            {
                c.GetStringFromUI();  // изменяем значение строки
                Console.WriteLine("Чтобы закончить эксперименты, нажмите ESC...");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
