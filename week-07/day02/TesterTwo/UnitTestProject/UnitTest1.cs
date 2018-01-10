using NUnit.Framework;
using TesterTwo;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        Anagram anagram = new Anagram();

        [Test]
        public void IsStringTest()
        {
            Assert.True(anagram.IsAnagram("dog", "cat"));
        }

        [Test]
        public void IsStringTest()
        {
            Assert.True(anagram.IsAnagram("dog", "cat"));
        }
    }
}
