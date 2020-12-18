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

        [Test]
        public void TestEmpty()
        {
            List<int> testList = new List<int>();
            int testRes = MyMath.Operations.Max(testList);
            Assert.AreEqual(testRes, 0);
        }

        [Test]
        public void TestMixed()
        {
            List<int> testList = new List<int>();
            testList.Add(2);
            testList.Add(0);
            testList.Add(1);
            testList.Add(-1);

            int testRes = MyMath.Operations.Max(testList);
            Assert.AreEqual(testRes, 2);
        }

        [Test]
        public void TestMulti()
        {
            List<int> testList = new List<int>();
            testList.Add(0);
            testList.Add(0);
            testList.Add(2);
            testList.Add(2);

            int testRes = MyMath.Operations.Max(testList);
            Assert.AreEqual(testRes, 2);
        }

        [Test]
        public void TestNeg()
        {
            List<int> testList = new List<int>();
            testList.Add(-8);
            testList.Add(-20);
            testList.Add(-5);
            testList.Add(-7);

            int testRes = MyMath.Operations.Max(testList);
            Assert.AreEqual(testRes, -5);
        }
    }
}