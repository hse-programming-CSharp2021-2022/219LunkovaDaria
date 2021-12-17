using System;

namespace Task_01
{
    // Задача 3 из презентации к семинару 2_01a

    class Polygon
    {
        public int N { get; set; }
        public double R { get; set; }
        public Polygon(int n = 0, double r = 0)
        {
            N = n; 
            R = r;
        }
        public string PolygonData()
        {
            return $"n = {N}, r = {R}, P = {Perimeter:f3}, S = {Square:f3} ";
        }
        public double Perimeter
        {
            get { return 2 * N * R * Math.Tan(Math.PI / N); }
        }
        public double Square
        {
            get { return R * Perimeter / 2; }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = 10;
            Polygon[] t = new Polygon[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                t[i] = new Polygon(random.Next(1, 10), random.Next(1, 10) + random.NextDouble());
                Console.WriteLine(t[i].PolygonData());
            }
        }
    }
}
