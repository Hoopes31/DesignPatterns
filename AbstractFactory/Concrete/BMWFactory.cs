using System;

namespace AbstractFactory
{
    public class BMWFactory : IAutoFactory
    {
        public string FactoryName { get; set; }

        public BMWFactory()
        {
            FactoryName = "BMW";
        }

        // Plain Factory Return
        public IVehicle BuildVehicle(string model)
        {
            if (model.Equals("HP4", StringComparison.OrdinalIgnoreCase))
            {
                return new BMWMotorcycle("HP4");
            }
            if (model.Equals("G310R", StringComparison.OrdinalIgnoreCase))
            {
                return new BMWMotorcycle("G310R");
            }
            if (model.Equals("M5", StringComparison.OrdinalIgnoreCase))
            {
                return new BMWCar("M5");
            }
            if (model.Equals("M4", StringComparison.OrdinalIgnoreCase))
            {
                return new BMWCar("M4");
            }
            throw new ArgumentException($"{model} model not found");
        }

        // Factory Method
        public void StartVehicle(string model)
        {
            IVehicle vehicle;

            if (model.Equals("HP4", StringComparison.OrdinalIgnoreCase))
            {
                vehicle = new BMWMotorcycle("HP4");
                Console.WriteLine($"The {FactoryName} factory fires up the {vehicle.Model}'s engine");
                return;
            }
            if (model.Equals("G310R", StringComparison.OrdinalIgnoreCase))
            {
                vehicle = new BMWMotorcycle("G310R");
                Console.WriteLine($"The {FactoryName} factory fires up the {vehicle.Model}'s engine");
                return;
            }
            if (model.Equals("M5", StringComparison.OrdinalIgnoreCase))
            {
                vehicle = new BMWCar("M5");
                Console.WriteLine($"The {FactoryName} factory fires up the {vehicle.Model}'s engine");
                return;
            }
            if (model.Equals("M4", StringComparison.OrdinalIgnoreCase))
            {
                vehicle = new BMWCar("M4");
                Console.WriteLine($"The {FactoryName} factory fires up the {vehicle.Model}'s engine");
                return;
            }
            throw new ArgumentException($"{model} model not found");
        }

        #region Classes
        // Concrete Classes
        public class BMWMotorcycle : Motorcycle, IVehicle
        {
            public string Model { get; set; }

            public BMWMotorcycle(string model)
            {
                Model = model;
            }
            public void StartEngine()
            {
                Console.WriteLine($"{Model} prepares to fly on {Wheels} wheels");
            }
        }
        public class BMWCar : Car, IVehicle
        {
            public string Model { get; set; }

            public BMWCar(string model)
            {
                Model = model;
            }
            public void StartEngine()
            {
                Console.WriteLine($"{Model} prepares to fly on {Wheels} wheels");
            }
        }
        #endregion
    }
}
