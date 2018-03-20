using Bridge.Concrete;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new Message();
            
            message.MessageSender = new ConsoleMessageSender();
            message.Send("Hello.");

            message.MessageSender = new TextMessageSender();
            message.Send("Hello, again!");
        }
    }
}
