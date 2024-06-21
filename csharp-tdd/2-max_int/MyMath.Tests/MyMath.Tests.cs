using NUnit.Framework;
using System;
using System.Collections.Generic;
using MyMath;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestMax()
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            int result = Operations.Max(nums);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void TestMaxEmpty()
        {
            List<int> nums = new List<int> { };
            int result = Operations.Max(nums);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestMaxNegative()
        {
            List<int> nums = new List<int> { -1, -2, -3, -4, -5 };
            int result = Operations.Max(nums);
            Assert.AreEqual(-1, result);
        }
    }
}