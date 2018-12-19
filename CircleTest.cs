using System;
using GeometricFigures;
using NUnit.Framework;

namespace GeometricTest
{
    [TestFixture]
    public class CircleTest
    {
        [Test, TestCaseSource("CircleCases")]
        public void TestMethod(int radius, int area, int length)
        {
            Circle circle = new Circle(radius);
            Assert.AreEqual(area, System.Math.Round(circle.getAreaCircle()));
            Assert.AreEqual(length, System.Math.Round(circle.getLengthCircle()));
        }

        static object[] CircleCases =
        {
             new object[] { 0, 0, 0 },
             new object[] { 3, 28, 19 },
             new object[] { 6, 113, 38 },
             new object[] { 9, 254, 57 },
             new object[] { 12, 452, 75 },
             new object[] { 15, 707, 94 },
             new object[] { 18, 1018, 113 }
        };
    }

}
