using Facade.Facade;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new CarFacade();

            // This simple facade method activates more complex subsystems
            facade.CreateCompleteCar();
        }
    }
}
