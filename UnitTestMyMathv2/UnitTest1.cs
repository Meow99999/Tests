using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using MyMathv2;

namespace UnitTestMyMathv2
{
    [TestClass]
    public class UnitTestGeometry
    {
        [TestMethod]
        public void SRectanglea2b2c4()
        {
            double a = 2;
            double b = 2;
            double c = 4;

            double result = Geometry.SRectangle(a, b);

            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void SRectanglea4b4c16()
        {
            double a = 4;
            double b = 4;
            double c = 16;

            double result = Geometry.SRectangle(a, b);

            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void SRectanglea4b4c8()
        {
            double a = 4;
            double b = 2;
            double c = 8;

            double result = Geometry.SRectangle(a, b);

            Assert.AreEqual(c, result);
        }

        ////////////////////

        [TestMethod]
        public void SVersatileTriangle5b10c25()
        {
            double a = 5;
            double b = 10;
            double c = 25;

            double result = Geometry.SVersatileTriangle(a, b);

            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void SVersatileTriangle5b10c24()
        {
            double a = 5;
            double b = 10;
            double c = 24;

            double result = Geometry.SVersatileTriangle(a, b);

            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void SVersatileTriangle10b10c50()
        {
            double a = 10;
            double b = 10;
            double c = 50;

            double result = Geometry.SVersatileTriangle(a, b);

            Assert.AreEqual(c, result);
        }

        //////////////////////
        [TestMethod]
        public void SRightTrianglea5b10c25()
        {
            double a = 5;
            double b = 10;
            double c = 25;

            double result = Geometry.SRightTriangle(a, b);

            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void SRightTrianglea5b15c375()
        {
            double a = 5;
            double b = 15;
            double c = 37.5;

            double result = Geometry.SRightTriangle(a, b);

            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void SRightTrianglea10b30c150()
        {
            double a = 10;
            double b = 30;
            double c = 150;

            double result = Geometry.SRightTriangle(a, b);

            Assert.AreEqual(c, result);
        }

        //////////////

        [TestMethod]
        public void SCirclea5r31()
        {
            double a = 5;
            double r = 31.4159265358979;

            double result = Geometry.SCircle(a);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void SCirclea10r62()
        {
            double a = 10;
            double r = 62.8318530717959;

            double result = Geometry.SCircle(a);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void SCirclea15r94()
        {
            double a = 15;
            double r = 94.2477796076938;

            double result = Geometry.SCircle(a);

            Assert.AreEqual(r, result);
        }

        //////////
        [TestMethod]
        public void STrapezoida4b9c3r195()
        {
            double a = 4;
            double b = 9;
            double c = 3;
            double r = 19.5;

            double result = Geometry.STrapezoid(a, b, c);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void STrapezoida10b9c3r285()
        {
            double a = 10;
            double b = 9;
            double c = 3;
            double r = 28.5;

            double result = Geometry.STrapezoid(a, b, c);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void STrapezoida4b20c3r36()
        {
            double a = 4;
            double b = 20;
            double c = 3;
            double r = 36;

            double result = Geometry.STrapezoid(a, b, c);

            Assert.AreEqual(r, result);
        }

    }

    [TestClass]
    public class UnitTestTrigonometry
    {
        [TestMethod]
        public void Sina30()
        {
            double a = 30;
            double r = 0.5;

            double result = Trigonometry.Sin(a);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void Sina60()
        {
            double a = 25;
            double r = 0.422618261740699;

            double result = Trigonometry.Sin(a);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void Sina90()
        {
            double a = 90;
            double r = 1;

            double result = Trigonometry.Sin(a);

            Assert.AreEqual(r, result);
        }

        ///////////

        [TestMethod]
        public void Cosa30()
        {
            double a = 30;
            double r = 0.866025403784439;

            double result = Trigonometry.Cos(a);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void Cosa60()
        {
            double a = 60;
            double r = 0.5;

            double result = Trigonometry.Cos(a);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void Cosa10()
        {
            double a = 10;
            double r = 0.984807753012208;

            double result = Trigonometry.Cos(a);

            Assert.AreEqual(r, result);
        }

        ////////////////
        [TestMethod]
        public void Tgaa30()
        {
            double a = 30;
            double r = 0.577350269189626;

            double result = Trigonometry.Tga(a);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void Tgaa60()
        {
            double a = 60;
            double r = 1.73205080756888;

            double result = Trigonometry.Tga(a);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void Tgaa10()
        {
            double a = 10;
            double r = 0.176326980708465;

            double result = Trigonometry.Tga(a);

            Assert.AreEqual(r, result);
        }

        //////
        [TestMethod]
        public void CTgaa30()
        {
            double a = 30;
            double r = 1.73205080756888;

            double result = Trigonometry.Ctga(a);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void CTgaa60()
        {
            double a = 60;
            double r = 0.577350269189626;

            double result = Trigonometry.Ctga(a);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void CTgaa10()
        {
            double a = 10;
            double r = 5.67128181961771;

            double result = Trigonometry.Ctga(a);

            Assert.AreEqual(r, result);
        }

        ///
        [TestMethod]
        public void Asina1()
        {
            double a = 1;
            double r = 1.5707963267949;

            double result = Trigonometry.Asin(a);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void Asina2()
        {
            double a = -2;
            double r = 1.73205080756888;

            double result = Trigonometry.Asin(a);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void Asina3()
        {
            double a = -3;
            double r = 1.73205080756888;

            double result = Trigonometry.Asin(a);

            Assert.AreEqual(r, result);
        }

    }

    [TestClass]
    public class UnitTestAlgebra
    {
        [TestMethod]
        public void Sqra5()
        {
            double a = 5;
            double r = 2.23606797749979;

            double result = Algebra.Sqr(a);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void Sqra10()
        {
            double a = 10;
            double r = 3.16227766016838;

            double result = Algebra.Sqr(a);

            Assert.AreEqual(r, result);
        }

        [TestMethod]
        public void Sqra25()
        {
            double a = 25;
            double r = 5;

            double result = Algebra.Sqr(a);

            Assert.AreEqual(r, result);
        }
    }
}
