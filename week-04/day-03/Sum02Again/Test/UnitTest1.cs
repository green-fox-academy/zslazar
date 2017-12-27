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
        //ha static, akkor kell:
        //Program program = new Program();

        [Test]
        public void TestMethod1()
        {
            //arrange
            var program = new Program();
            //static


            //act
            //non static
            int result = program.Sum();
            //ha static akkor:
            //int result = Program.Sum();

            //assert
            Assert.AreEqual(9, result);
        }
    }
}
