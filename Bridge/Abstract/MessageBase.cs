namespace Bridge
{
    public abstract class MessageBase
    {
        public IMessageSender MessageSender;
        public abstract void Send(string message);
    }
}
