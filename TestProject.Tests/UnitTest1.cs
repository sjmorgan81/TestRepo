using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2 + 2, 4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4 + 4, 9);
        }
    }
}
