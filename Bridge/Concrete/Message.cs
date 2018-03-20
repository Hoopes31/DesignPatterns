using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Concrete
{
    public class Message : MessageBase
    {
        public override void Send(string message)
        {
            MessageSender.Send(message);
        }
    }
}
