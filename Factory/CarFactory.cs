using System;

namespace Factory
{
    // The factory returns a specific concrete class associated with the input. 
    // This all happens without the user needing to be involved with what is occuring under the hood
    // The car factory produces cars! Imagine that!
    public class CarFactory : ICarFactory
    {
        // Concrete Car Factory
        public ICar BuildVehicle(string make, string model)
        {
            if (make.Equals("Honda", StringComparison.OrdinalIgnoreCase))
            {
                return new Honda(model, make);
            }
            if (make.Equals("Toyota", StringComparison.OrdinalIgnoreCase))
            {
                return new Toyota(model, make);
            }
            if (make.Equals("Subaru", StringComparison.OrdinalIgnoreCase))
            {
                return new Subaru(model, make);
            }
            throw new ArgumentException("Vehical make not found");
        }
    }

    // Concrete Honda Class
    public class Honda : ICar
    {
        public string Model { get; set; }
        public string Make { get; set; }

        public Honda(string model, string make)
        {
            Model = model;
            Make = make;
        }
    }

    // Concrete Toyota Class
    public class Toyota : ICar
    {
        public string Model { get; set; }
        public string Make { get; set; }


        public Toyota(string model, string make)
        {
            Model = model;
            Make = make;
        }
    }

    // Concrete Subaru Class
    public class Subaru : ICar
    {
        public string Model { get; set; }
        public string Make { get; set; }


        public Subaru(string model, string make)
        {
            Model = model;
            Make = make;
        }
    }
}
