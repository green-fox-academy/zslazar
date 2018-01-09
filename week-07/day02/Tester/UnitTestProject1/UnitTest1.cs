using NUnit.Framework;
using Tester;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {

        GetIndex getIndex = new GetIndex();
            
        [Test]
        public void NonListItemTest()
        {
            List<string> list = new List<string>() { "cat", "dog" };

            Assert.AreEqual(-1, getIndex.Indexer(list, "whale"));

        }

        [Test]
        public void IndexOfFirstItemTest()
        {
            List<string> list = new List<string>() { "cat", "dog" };

            Assert.AreEqual(0, getIndex.Indexer(list, "cat"));
        }
    }
}
