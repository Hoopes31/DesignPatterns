using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new AutoFactoryProvider();

            // Abstract Factory Call
            var hondaFactory = AutoFactoryProvider.GetAutoFactory("Honda");
            var bmwFactory = AutoFactoryProvider.GetAutoFactory("BMW");

            // Plain Factory Call
            hondaFactory.BuildVehicle("CRF450R");
            bmwFactory.BuildVehicle("HP4");
            bmwFactory.BuildVehicle("M5");

            // Factory Method Call
            bmwFactory.StartVehicle("M5");

            // Hiding details to prepare of showing off of the abstract factories power!
            var listOfCars = new List<List<string>>()
            {
                new List<string> { "Honda", "TypeR" },
                new List<string> { "Honda", "CRF250R" },
                new List<string> { "BMW", "M4" },
                new List<string> { "BMW", "G310R" },
            };

            // Showing off abstracts polymorphic ways O.o
            foreach (var vehicleInfo in listOfCars)
            {
                var make = vehicleInfo[0];
                var model = vehicleInfo[1];

                // The user in this case could care less about the HondaFactory class, car class, motorcycle class, etc
                // Here they can use the abstract class to achieve all the same results with less headache!
                var abstractCarFactory = AutoFactoryProvider.GetAutoFactory(make);
                var car = abstractCarFactory.BuildVehicle(model);
                car.StartEngine();
            }


            Console.ReadKey();
        }
    }
}
