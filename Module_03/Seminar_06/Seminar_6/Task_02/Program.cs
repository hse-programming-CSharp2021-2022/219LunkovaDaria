using System;
using System.Collections.Generic;

namespace Task_02
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(double x0, double y0)
        {
            X = x0;
            Y = y0;
        }
        public double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow(X - point.X, 2) + Math.Pow(Y - point.X, 2));
        }
    }
    class TriangleComp : IComparable<TriangleComp>
    {
        private Point A, B, C;
        public double AB, BC, CA;
        public TriangleComp(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            A = new Point(x1, y1);
            B = new Point(x2, y2);
            C = new Point(x3, y3);
            AB = A.Distance(B);
            BC = B.Distance(C);
            CA = C.Distance(A);
        }
        public double Area
        {
            get
            {
                var k = (AB + BC + CA) / 2;
                return Math.Sqrt((k - AB) * (k - BC) * (k - CA) * k);
            }
        }

        public int CompareTo(TriangleComp other)
        {
            return this.Area.CompareTo(other.Area);
        }
        private double sign(Point p1, Point p2, Point p3)
        {
            return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
        }
        public bool TrianglePoint(Point pt)
        {
            double d1, d2, d3;
            bool has_neg, has_pos;
            d1 = sign(pt, A, B);
            d2 = sign(pt, B, C);
            d3 = sign(pt, C, A);
            has_neg = (d1 < 0) || (d2 < 0) || (d3 < 0);
            has_pos = (d1 > 0) || (d2 > 0) || (d3 > 0);
            return !(has_neg && has_pos);
        }
    }
    class TriangleCompComparer : IComparer<TriangleComp>
    {
        public int Compare(TriangleComp x, TriangleComp y)
        {
            double xp = x.AB + x.CA + x.BC;
            double yp = y.AB + y.CA + y.BC;
            return yp.CompareTo(xp);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TriangleComp p = new(0, 0, 0, 6, 7, 1);
            Console.WriteLine("Точка (1, 1) " + (p.TrianglePoint(new Point(1, 1)) ? "" : "не ") + "принадлежит треугольнику");
            Console.WriteLine("Точка (1, 7) " + (p.TrianglePoint(new Point(1, 7)) ? "" : "не ") + "принадлежит треугольнику");
        }
    }
}
