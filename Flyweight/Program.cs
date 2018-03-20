using Factory;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var flyweightFactory = new CarFactory();

            flyweightFactory.BuildVehicle("Honda");
            flyweightFactory.BuildVehicle("Toyota");

            flyweightFactory.GetAllCars();

            flyweightFactory.BuildVehicle("Subaru");
            flyweightFactory.BuildVehicle("Subaru");

            flyweightFactory.BuildVehicle("Ford");

            flyweightFactory.GetAllCars();
        }
    }
}
