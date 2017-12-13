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
        }
    }
}
