using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMathv2;

namespace NPDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rect " + Geometry.SRectangle(5, 10));
            Console.WriteLine("VersatileTrinle " + Geometry.SVersatileTriangle(5, 10));
            Console.WriteLine("RightTriangle " + Geometry.SRightTriangle(5, 10));
            Console.WriteLine("Circle " + Geometry.SCircle(5));
            Console.WriteLine("Trapezoid " + Geometry.STrapezoid(4, 9, 3));
            Console.WriteLine("Sin " + Trigonometry.Sin(30));
            Console.WriteLine("Cos " + Trigonometry.Cos(30));
            Console.WriteLine("Tga" + Trigonometry.Tga(30));
            Console.WriteLine("Ctga " + Trigonometry.Ctga(30));
            Console.WriteLine("Arcsin " + Trigonometry.Asin(1)) ;
            Console.WriteLine(Algebra.Sqr(10));
            Console.ReadKey();
        }
    }
}
