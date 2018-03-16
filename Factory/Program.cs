using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var carFactory = new CarFactory();
            var honda = carFactory.BuildVehicle("Honda", "Element");
            var toyota = carFactory.BuildVehicle("Toyota", "Prius");
            var subaru = carFactory.BuildVehicle("Subaru", "Impreza");

            Console.WriteLine($"My three cars are a {honda.Make} {honda.Model}, {toyota.Make} {toyota.Model} and a {subaru.Make} {subaru.Model}");
            Console.ReadKey();
        }
    }
}
