using _02_Sum;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestingSumProject
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestSumming_Integers()
        {
            List<int> listOfIntegers = new List<int>() { 2, 3, 4, 5 };
            var sum = new Sum();

            int output = 14;

            Assert.AreEqual(output, sum.Summing(listOfIntegers));
        }

        [Test]
        public void TestSumming_EmptyList()
        {
            var sum = new Sum();
            List<int> emptyList = new List<int>();

            Assert.AreEqual(0, sum.Summing(emptyList));
        }

        [Test]
        public void TestSumming_OneElement()
        {
            var sum = new Sum();
            List<int> oneElement = new List<int>() { 5 };

            Assert.AreEqual(5, sum.Summing(oneElement));
        }
    }
}
