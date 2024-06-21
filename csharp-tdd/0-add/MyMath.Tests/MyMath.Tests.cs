using NUnit.Framework;
using System;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_ReturnsSumOfPositiveIntegers()
        {
            int a = 5;
            int b = 10;
            int expected = 15;
            int actual = Operations.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_ReturnsSumOfNegativeIntegers()
        {
            int a = -5;
            int b = -10;
            int expected = -15;
            int actual = Operations.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_ReturnsSumOfPositiveAndNegativeIntegers()
        {
            int a = 5;
            int b = -10;
            int expected = -5;
            int actual = Operations.Add(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}