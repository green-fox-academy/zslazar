using NUnit.Framework;
using ConsoleApp1;


namespace UnitTestProject1
{
    [TestFixture]
    public class MessageUtilTests
    {
        [Test]
        public void PrintMessageTest()
        {
            //arrange
            string message = "Hello World";
            var messageUtil = new MessageUtil(message);

            //act
            string output = messageUtil.PrintMessage();

            //assert
            Assert.AreEqual(message, output);

            //////////////////////////////////
            //megadod az ertekeket es h azokat h minek akarod megfeleltetni
            //lenti pelda 1,2,3 mint x es 4,5,6 etrek mint y
            MathTask m = new MathTask();
            public void Add([Values(1, 2, 3)] double x [Values(4, 5, 6)] double y)
            {
                var result = m.Add(x, y);
                Assert.AreEqual(10, x);
            }

        }

    }
}
