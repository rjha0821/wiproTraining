// namespace XUnitProject;
using Xunit;
namespace XUnitProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddition()
        {
            int a = 5, b = 3;
            int result = a + b;
            Assert.Equal(8, result);
        }
    }
}