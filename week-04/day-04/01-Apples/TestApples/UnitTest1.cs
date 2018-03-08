using _01_Apples;
using NUnit.Framework;

namespace TestApples
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestGetApple()
        {
            var apple = new Apple();
            Assert.AreEqual("apple", apple.GetApple());
        }
    }
}
