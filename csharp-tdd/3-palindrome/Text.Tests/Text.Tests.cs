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
            Assert.True(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        [Test]
        public void TestIsNotPalindrome()
        {
            Assert.False(Str.IsPalindrome("A girl, a plan, a canal: Panama."));
        }

        [Test]
        public void TestEmptyString()
        {
            Assert.True(Str.IsPalindrome(""));
        }
    }
}