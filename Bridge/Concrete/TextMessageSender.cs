using System;

namespace Bridge.Concrete
{
    public class TextMessageSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"TEXT MESSAGE: {message}");
        }
    }
}
