using Proxy.Concrete;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            MathProxy proxy = new MathProxy();
            var value = proxy.Add(1, 2);
            System.Console.WriteLine($"Adding 1 & 2 equals: {value}");
        }
    }
}
