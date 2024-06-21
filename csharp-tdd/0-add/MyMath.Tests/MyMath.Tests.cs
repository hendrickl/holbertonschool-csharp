using NUnit.Framework;
using System;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_ReturnsSumOfArguments()
        {
            int result = Operations.Add(1, 2);
            Assert.AreEqual(3, result);
        }
    }
}