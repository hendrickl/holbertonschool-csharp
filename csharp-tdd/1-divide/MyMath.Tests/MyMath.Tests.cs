using NUnit.Framework;
using System;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Divide_WhenNumIsZero_ShouldReturnNull()
        {
            int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int num = 0;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(null, result);
        }

        [Test]
        public void Divide_WhenMatrixIsNull_ShouldReturnNull()
        {
            int[,] matrix = null;
            int num = 2;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(null, result);
        }

        [Test]
        public void Divide_WhenMatrixIsNotNull_ShouldReturnResult()
        {
            int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int num = 2;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(2, result[0, 1]);
            Assert.AreEqual(3, result[1, 0]);
            Assert.AreEqual(4, result[1, 1]);
        }
    }
}