using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace triangles
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void IsTriangleAllZeroTest()
        {
            Assert.IsFalse(Triangle.IsTriangle(0, 0, 0));
        }
        [TestMethod]
        public void IsTriangleThreeIdenticalTest()
        {
            Assert.IsTrue(Triangle.IsTriangle(5, 5, 5));
        }

        [TestMethod]
        public void IsTriangleTwoIdenticalTest()
        {
            Assert.IsTrue(Triangle.IsTriangle(4, 4, 3));
        }

        [TestMethod]
        public void IsTriangleRightTest()
        {
            Assert.IsTrue(Triangle.IsTriangle(5, 8, 10));
        }

        [TestMethod]
        public void IsTriangleBadTest()
        {
            Assert.IsFalse(Triangle.IsTriangle(3, 4, 9));
        }

        [TestMethod]
        public void IsTriangleGoodTest()
        {
            Assert.IsTrue(Triangle.IsTriangle(3, 4, 5));
        }

        [TestMethod]
        public void IsTriangleOneNegativeSideTest()
        {
            Assert.IsFalse(Triangle.IsTriangle(3, -4, 5));
        }

        [TestMethod]
        public void IsTriangleTwoNegativeSidesGoodTest()
        {
            Assert.IsFalse(Triangle.IsTriangle(-3, -4, 5));
        }

        [TestMethod]
        public void IsTriangleThreeNegativeSidesGoodTest()
        {
            Assert.IsFalse(Triangle.IsTriangle(-3, -4, -5));
        }

        [TestMethod]
        public void IsTriangleDoubleGoodTest()
        {
            Assert.IsTrue(Triangle.IsTriangle(3.9, 1.9, 5.7));
        }
    }
}
