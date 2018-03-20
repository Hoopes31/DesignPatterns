using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Concrete
{
    public class ConsoleMessageSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"CONSOLE MESSAGE: {message}");
        }
    }
}
