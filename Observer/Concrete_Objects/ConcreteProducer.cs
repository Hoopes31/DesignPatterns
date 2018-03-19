using System;
using System.Collections.Generic;

namespace Observer.Concrete_Objects
{
    public class ConcreteProducer : IProducer
    {
        private List<IObserver> _observerList;
        private string _name;

        public ConcreteProducer(string name)
        {
            _name = name;
            _observerList = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            _observerList.Add(observer);
        }

        // Action here, causes action in the observer
        public void Notify(string message)
        {
            foreach (var observer in _observerList)
            {
                // Call observers update function to trigger action
                observer.UpdateObserver($"{_name} says, \"{message}\"");
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            _observerList.Remove(observer);
        }
    }
}
