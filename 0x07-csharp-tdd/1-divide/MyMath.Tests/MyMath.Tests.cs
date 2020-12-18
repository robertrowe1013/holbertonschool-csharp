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
            int[,] testMatrix = new int[,]{{2,4}, {6,8}};
            int[,] testResMatrix = new int[,]{{1,2}, {3,4}};
            
            int[,] resMatrix = MyMath.Matrix.Divide(testMatrix, 2);

            Assert.AreEqual(testResMatrix, resMatrix);
        }
    }
}