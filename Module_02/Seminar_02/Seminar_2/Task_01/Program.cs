using System;

namespace Task_01
{
    // Задача 1 из презентации к семинару 2_01b
    class MyComplex
    {
        public double Re { get; set; }
        public double Im { get; set; }
        public MyComplex(double xre, double xim)
        { Re = xre; Im = xim; }
        public static MyComplex operator ++(MyComplex mc)
        {
            return new MyComplex(mc.Re + 1, mc.Im + 1);
        }
        public static MyComplex operator --(MyComplex mc)
        {
            return new MyComplex(mc.Re - 1, mc.Im - 1);
        }
        public double Mod() { return Math.Abs(Re * Re + Im * Im); }
        public static bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }
        public static bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }
        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.Re + b.Re, a.Im + b.Im);
        }
        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.Re - b.Re, a.Im - b.Im);
        }
        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.Re * b.Re - a.Im * b.Im, a.Im * b.Re + a.Re * b.Im);
        }
        public static MyComplex operator /(MyComplex a, MyComplex b)
        {
            return new MyComplex((a.Re * b.Re + a.Im * b.Im) / (b.Re * b.Re + b.Im * b.Im), (a.Im * b.Re - a.Re * b.Im) / (b.Re * b.Re + b.Im * b.Im));
        }
        public static void Display (MyComplex cs)
        {
            Console.WriteLine($"real = {cs.Re}, im = {cs.Im} ");
        }       
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyComplex c1 = new MyComplex(4, 3.3);
            Console.WriteLine("Модуль исходного комплексного числа = " + c1.Mod());

            while (c1)
            {
                Console.Write("c1 => ");
                MyComplex.Display(c1);
                c1--;
            }
            Console.WriteLine("Модуль полученного числа = " + c1.Mod());
        }
    }
}
