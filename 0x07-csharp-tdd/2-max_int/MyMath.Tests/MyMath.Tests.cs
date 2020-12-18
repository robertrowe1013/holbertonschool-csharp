using NUnit.Framework;
using System.Collections.Generic;

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
            List<int> testList = new List<int>();
            testList.Add(-1);
            testList.Add(0);
            testList.Add(1);
            testList.Add(2);
            int testRes = MyMath.Operations.Max(testList);
            Assert.AreEqual(testRes, 2);
        }
    }
}