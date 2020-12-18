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
            Assert.AreEqual(Text.Str.CamelCase("thisIsATest"), 4);
        }

        [Test]
        public void TestNull()
        {
            Assert.AreEqual(Text.Str.CamelCase(null), 0);
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(Text.Str.CamelCase(""), 0);
        }
        
        [Test]
        public void TestOne()
        {
            Assert.AreEqual(Text.Str.CamelCase("yep"), 1);
        }
    }
}