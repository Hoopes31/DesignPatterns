using Proxy.Abstract;

namespace Proxy.Concrete
{
    public class MathProxy : IMath
    {
        // Private variable inside of the the MathProxy extends the concrete Math object
        // The proxy's implementation object can easily be switched out for another object should we need a different implementation
        private Math _math = new Math();

        public double Add(double x, double y)
        {
            return _math.Add(x, y);
        }

        public double Divide(double x, double y)
        {
            return _math.Divide(x, y);
        }

        public double Multiply(double x, double y)
        {
            return _math.Multiply(x, y);
        }

        public double Subtract(double x, double y)
        {
            return _math.Subtract(x, y);
        }
    }
}
