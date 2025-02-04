using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            int a = 5, b = 3;
            int result = a + b;
            Assert.AreEqual(8, result, "Addition test failed.");
        }
    }
}
