using GeometricFigures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricTest
{
    [TestFixture]
    public class TriangleTest
    {
        [Test, TestCaseSource("TriangleCases")]
        public void TestMethod(int side, int area, int length)
        {
            Triangle triangle = new Triangle(side,side,side);
            Assert.AreEqual(area, System.Math.Round(triangle.getAreaTriangle()));
            Assert.AreEqual(length, System.Math.Round(triangle.getLengthTriangle()));
        }

        static object[] TriangleCases =
        {
             new object[] { 2, 2, 6 },
             new object[] { 5, 11, 15 },
             new object[] { 8, 28, 24 },
             new object[] { 11, 52, 33 },
             new object[] { 14, 85, 42 },
             new object[] { 17, 125, 51 },
             new object[] { 20, 173, 60 }
        };

        [Test, TestCaseSource("ImpossibleCases")]
        public void TestMethodImpossible(int side1, int side2,int side3)
        {
            Triangle triangle = new Triangle(side1, side2, side3);
            Assert.IsNaN(triangle.getAreaTriangle());
            Assert.IsNaN(triangle.getLengthTriangle());
        }

        static object[] ImpossibleCases =
        {
             new object[] { 2, 2, 6 },
             new object[] { 1, 2, 4 },
             new object[] { 1, 2, 3 },
             new object[] { 11, 5, 30 },
        };
    }
}
