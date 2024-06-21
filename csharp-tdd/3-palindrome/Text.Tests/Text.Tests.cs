using NUnit.Framework;
using Text;

namespace Tests.Text
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestIsPalindrome()
        {
            Assert.True(Str.IsPalindrome("racecar"));
        }

        [Test]
        public void TestIsNotPalindrome()
        {
            Assert.False(Str.IsPalindrome("hello"));
        }

        [Test]
        public void TestEmptyString()
        {
            Assert.True(Str.IsPalindrome(""));
        }
    }
}