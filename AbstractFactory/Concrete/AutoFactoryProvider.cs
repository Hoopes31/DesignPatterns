using System;

namespace AbstractFactory
{
    public class AutoFactoryProvider
    {
        public static IAutoFactory GetAutoFactory(string make)
        {
            if (make.Equals("Honda", StringComparison.OrdinalIgnoreCase))
            {
                return new HondaFactory();
            }
            if (make.Equals("BMW", StringComparison.OrdinalIgnoreCase))
            {
                return new BMWFactory();
            }
            throw new ArgumentException($"Our system does not have a {make} auto factory");
        }
    }
}
