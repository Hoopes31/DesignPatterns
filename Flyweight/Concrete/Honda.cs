using Factory;

namespace Flyweight.Concrete
{
    // Concrete Honda Class
    public class Honda : ICar
    {
        public string Make { get; set; }

        public Honda(string make)
        {
            Make = make;
        }
    }


    
}
