using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestRunTrue()
        {
            Assert.True(Text.Str.IsPalindrome("abba"));
        }

        [Test]
        public void TestRunFalse()
        {
            Assert.False(Text.Str.IsPalindrome("abc"));
        }

        [Test]
        public void TestNonLetters()
        {
            Assert.True(Text.Str.IsPalindrome("ABb, a!"));
        }

        [Test]
        public void TestEmpty()
        {
            Assert.True(Text.Str.IsPalindrome(""));
        }
    }
}