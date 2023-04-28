using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrarys;

namespace MathTaskClassLibrarysTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void Rectangle()
        {

            int a = 3;
            int b = 5;
            int expected = 15;

            Geometry g = new Geometry();
            int actual = g.Rectangle(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Cylinder()
        {
            double a = 3;
            double b = 5;
            double expected = 141.37;

            Geometry g = new Geometry();
            double actual = g.Cylinder(a, b);

            Assert.AreEqual(expected, actual);

        }
    }
}