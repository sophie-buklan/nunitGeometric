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
    public class SquareTest
    {
        [Test, TestCaseSource("SquareCases")]
        public void TestMethod(int side, int area, int length)
        {
            Square square = new Square(side);
            Assert.AreEqual(area, square.getAreaSquare());
            Assert.AreEqual(length, square.getLengthSquare());
        }

        static object[] SquareCases =
        {
             new object[] { 1, 1, 4 },
             new object[] { 4, 16, 16 },
             new object[] { 7, 49, 28 },
             new object[] { 10, 100, 40 },
             new object[] { 13, 169, 52 },
             new object[] { 16, 256, 64 },
             new object[] { 19, 361, 76 }
        };
    }
}
