using System;

namespace Observer.Concrete_Objects
{
    public class ConcreteObserver : IObserver
    {
        private string _name;

        public ConcreteObserver(string name)
        {
            _name = name;
        }
        // Response to Producer action
        public void UpdateObserver(string message)
        {
            Console.WriteLine($"{message}. Message is received by {_name}");
        }
    }
}
