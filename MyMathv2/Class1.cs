using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathv2
{
    public class Geometry
    {
        public static double SRectangle(double a, double b)
        {
            return a * b;
        }

        public static double SVersatileTriangle(double a, double h)
        {
            return (a * h) / 2;
        }

        public static double SRightTriangle(double a, double b)
        {
            return (a * b) / 2;
        }

        public static double SCircle(double r)
        {
            return 2 * Math.PI * r;
        }

        public static double STrapezoid(double a, double b, double h)
        {
            return (a + b) / 2 * h;
        }
    }

    public class Trigonometry
    {
        public static double Sin(double a)
        {
            return Math.Sin(a * Math.PI / 180);
        }

        public static double Cos(double a)
        {
            return Math.Cos(a * Math.PI / 180);
        }

        public static double Tga(double a)
        {
            return Math.Tan(a * Math.PI / 180);
        }
        public static double Ctga(double a)
        {
            return 1 / Math.Tan(a * Math.PI / 180);
        }

        public static double Asin(double a)
        {
            return Math.Asin(a);
        }

    }

    public class Algebra
    {
        public static double Sqr(double a)
        {
            return Math.Sqrt(a);
        }
    }
}
