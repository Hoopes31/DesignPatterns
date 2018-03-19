using Observer.Concrete_Objects;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var producer1 = new ConcreteProducer("Producer #1");
            var producer2 = new ConcreteProducer("Producer #2");

            var observer1 = new ConcreteObserver("Observer #1");
            var observer2 = new ConcreteObserver("Observer #2");
            var observer3 = new ConcreteObserver("Observer #3");

            // Producer1 addes only observer 1
            producer1.AddObserver(observer1);

            // Producer2 is much more popular and adds all observers
            producer2.AddObserver(observer1);
            producer2.AddObserver(observer2);
            producer2.AddObserver(observer3);

            // When producer1 notifies we only see one action in the console
            producer1.Notify("Hello faithful subjects");

            // When producer2 notifies we see 3 actions occur in the console
            producer2.Notify("Hello fellow citizens");
        }
    }
}
