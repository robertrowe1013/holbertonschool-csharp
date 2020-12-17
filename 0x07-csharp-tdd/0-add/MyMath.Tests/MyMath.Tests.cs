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
        public void Test_Num()
        {
            int sum = MyMath.Operations.Add(1, 1);
            Assert.AreEqual(sum, 2);
        }
    }
}