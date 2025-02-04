using NUnit.Framework;
namespace NUnitProject
{
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddition()
        {
            int a = 5, b = 3;
            int result = a + b;
            Assert.AreEqual(9, result, "Addition test failed.");
        }
    }
}