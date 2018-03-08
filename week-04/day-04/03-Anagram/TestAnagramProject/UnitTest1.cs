using NUnit.Framework;
using _03_Anagram;

namespace TestAnagramProject
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        [TestCase( "roma", "amor")]
        [TestCase("Roma", "mora")]
        public void TestIsAnagram(string word1, string word2)
        {
            var anagram = new Anagram();
            Assert.IsTrue(anagram.IsAnagram(word1, word2));
        }

        [Test]
        [TestCase("jo", "ro" )]
        [TestCase("aaad", "aadd")]
        [TestCase("a", "aa")]
        public void TestIsAnagram_False(string word1, string word2)
        {
            var anagram = new Anagram();
            Assert.IsFalse(anagram.IsAnagram(word1, word2));
        }
    }
}
