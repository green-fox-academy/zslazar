using NUnit.Framework;
using _01_Apples;

namespace Test
{
//Instantiate your class (arrange, act, assert)
//Use the Assert.AreEqual()
//The expected parameter should be the same string (eg. "apple")
//The actual parameter should be the return value of the method(eg.myObject.GetApple())
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //arrange
            string message = "apple";
            var apples = new Apples(message);

            //act
            string output = apples.PrintMessage();

            //assert
            //zarojelben az elso az elvart eredmeny a masodik a tesztelt
            Assert.AreEqual(message, output);
        }
    }
}
