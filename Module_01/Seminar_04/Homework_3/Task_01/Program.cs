using System;

namespace Task_01
{
    class Program
    {
        public static bool inG(double x, double y)
        {
            double atan = Math.Atan2(y, x);
            return (x * x + y * y <= 4) && (-0.5 * Math.PI <= atan) && (atan <= 0.25 * Math.PI);
        }

        static void Main(string[] args)
        {
            double x, y;
            do 
            { 
                Console.Write("Введите x: "); 
            } while (!double.TryParse(Console.ReadLine(), out x));
            do
            {
                Console.Write("Введите y: ");
            } while (!double.TryParse(Console.ReadLine(), out y));

            if (inG(x,y)) { Console.WriteLine("Точка попадает в фигуру."); }
            else { Console.WriteLine("Точка не попадает в фигуру. "); }
        }
    }
}
