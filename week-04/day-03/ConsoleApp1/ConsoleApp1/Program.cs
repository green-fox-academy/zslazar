using System;

namespace ConsoleApp1
{
    public class MessageUtil
    {
        private string message;

        public MessageUtil(string message)
        {
            this.message = message;
        }

        public string PrintMessage()
        {
            Console.WriteLine(message);
            return message;
        }
    }
}
