using Factory;

namespace Flyweight.Concrete
{
    // Concrete Subaru Class
    public class Subaru : ICar
    {
        public string Make { get; set; }

        public Subaru(string make)
        {
            Make = make;
        }
    }
}
