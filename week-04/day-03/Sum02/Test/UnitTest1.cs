using Sum02;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;


namespace Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //arrange
            var numbers = new List<int> { 8, 2, 6, 3 };

            //act
            int sum = numbers.Sum();

            //assert
            Assert.AreEqual(19, sum);
        }

        [Test]
        public void TestMethod2()
        {
            //arrange
            var numbers = new List<int> { 8};

            //act
            int sum = numbers.Sum();

            //assert
            Assert.AreEqual(8, sum);
        }

        [Test]
        public void TestMethod3()
        {
            //arrange
            var elements = new List<int> { 8, 10, 23, 75 };

            //act
            int allin = elements.Sum();

            //assert
            Assert.AreEqual(116, allin);
        }
    }
}
