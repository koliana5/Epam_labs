using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsTriangleAllZeroTest()
        {
            Assert.IsFalse(WorkWithTriangles.IsTriangle(0, 0, 0));
        }
        [TestMethod]
        public void IsTriangleThreeIdenticalTest()
        {
            Assert.IsTrue(WorkWithTriangles.IsTriangle(5, 5, 5));
        }

        [TestMethod]
        public void IsTriangleTwoIdenticalTest()
        {
            Assert.IsTrue(WorkWithTriangles.IsTriangle(4, 4, 3));
        }

        [TestMethod]
        public void IsTriangleRightTest()
        {
            Assert.IsTrue(WorkWithTriangles.IsTriangle(5, 8, 10));
        }

        [TestMethod]
        public void IsTriangleBadTest()
        {
            Assert.IsFalse(WorkWithTriangles.IsTriangle(3, 4, 9));
        }

        [TestMethod]
        public void IsTriangleGoodTest()
        {
            Assert.IsTrue(WorkWithTriangles.IsTriangle(3, 4, 5));
        }

        [TestMethod]
        public void IsTriangleOneNegativeSideTest()
        {
            Assert.IsFalse(WorkWithTriangles.IsTriangle(3, -4, 5));
        }

        [TestMethod]
        public void IsTriangleTwoNegativeSidesGoodTest()
        {
            Assert.IsFalse(WorkWithTriangles.IsTriangle(-3, -4, 5));
        }

        [TestMethod]
        public void IsTriangleThreeNegativeSidesGoodTest()
        {
            Assert.IsFalse(WorkWithTriangles.IsTriangle(-3, -4, -5));
        }

        [TestMethod]
        public void IsTriangleDoubleGoodTest()
        {
            Assert.IsTrue(WorkWithTriangles.IsTriangle(3.9, 1.9, 5.7));
        }
    }
}
