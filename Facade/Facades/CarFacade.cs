using Facade.Subsystems;

namespace Facade.Facade
{
    public class CarFacade
    {
        private readonly CarEngine engine;
        private readonly CarSeats seats;
        private readonly CarStereo stereo;
        private readonly CarWheels wheels;

        public CarFacade()
        {
            engine = new CarEngine();
            seats = new CarSeats();
            stereo = new CarStereo();
            wheels = new CarWheels();
        }

        public void CreateCompleteCar()
        {
            System.Console.WriteLine("Creating car...");

            // Enact subsystems
            engine.SetEngine();
            seats.SetSeats();
            stereo.SetStereo();
            wheels.SetWheels();

            System.Console.WriteLine("Car completed.");

        }
    }
}
