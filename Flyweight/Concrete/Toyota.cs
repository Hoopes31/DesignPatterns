using Factory;

namespace Flyweight.Concrete
{
    // Concrete Toyota Class
    public class Toyota : ICar
    {
        public string Make { get; set; }

        public Toyota(string make)
        {
            Make = make;
        }
    }
}
