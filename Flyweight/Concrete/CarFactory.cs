using Flyweight.Concrete;
using System;
using System.Collections.Generic;

namespace Factory
{
    // Concrete Flyweight Car Factory
    // Flyweights only create objects if they have not yet been created
    // In this case the flyweight factory for cars will tell the user 
    // they can only have one type of each car if they try to make and already created one.
    public class CarFactory : ICarFactory
    {
        Dictionary<string, ICar> cars = new Dictionary<string, ICar>();

        // Prints all made cars
        public void GetAllCars()
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.Key);
            }
        }

        // Builds requested vehicle if we haven't already
        public void BuildVehicle(string make)
        {
            ICar car = null;

            // If we already have that vehicle don't create another
            if (cars.ContainsKey(make))
            {
                Console.WriteLine("You can only have one of each type of car.");
                return;
            }

            // Create all new vehicles
            if (make.Equals("Honda", StringComparison.OrdinalIgnoreCase))
            {
                car = new Honda(make);
                cars.Add(make, car);
                return;
            }
            if (make.Equals("Toyota", StringComparison.OrdinalIgnoreCase))
            {
                car = new Toyota(make);
                cars.Add(make, car);
                return;
            }
            if (make.Equals("Subaru", StringComparison.OrdinalIgnoreCase))
            {
                car = new Subaru(make);
                cars.Add(make, car);
                return;
            }

            // If this factory doesn't make the requested vehicle let the user know
            Console.WriteLine($"This factory does not make {make} vehicles.");
            return;
        }
    }

    
}
