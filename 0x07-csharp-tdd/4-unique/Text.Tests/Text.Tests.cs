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
        public void TestRun()
        {
            Assert.AreEqual(Text.Str.UniqueChar("a"), 0);
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(Text.Str.UniqueChar(""), -1);
        }

        [Test]
        public void TestNone()
        {
            Assert.AreEqual(Text.Str.UniqueChar("aa"), -1);
        }
    }
}