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
    }
}
