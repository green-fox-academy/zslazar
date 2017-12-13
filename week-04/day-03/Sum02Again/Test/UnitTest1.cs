using System;
using System.Collections.Generic;
using System.Text;
using Sum02Again;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //arrange
            var program = new Program();

            //act
            int result = program.Sum();

            //assert
            Assert.AreEqual(9, result);
        }
    }
}
