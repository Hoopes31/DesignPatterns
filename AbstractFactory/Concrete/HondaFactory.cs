using System;

namespace AbstractFactory
{
    public class HondaFactory : IAutoFactory
    {
        public string FactoryName { get; set; }

        public HondaFactory()
        {
            FactoryName = "Honda";
        }

        // Plain Factory Return
        public IVehicle BuildVehicle(string model)
        {
            if (model.Equals("CRF450R", StringComparison.OrdinalIgnoreCase))
            {
                return new HondaMotorcycle("CRF450R");
            }
            if (model.Equals("CRF250R", StringComparison.OrdinalIgnoreCase))
            {
                return new HondaMotorcycle("CRF250R");
            }
            if (model.Equals("TypeR", StringComparison.OrdinalIgnoreCase))
            {
                return new HondaCar("TypeR");
            }
            if (model.Equals("Coupe", StringComparison.OrdinalIgnoreCase))
            {
                return new HondaCar("Coupe");
            }
            throw new ArgumentException($"{model} model not found");
        }

        // Factory Method
        public void StartVehicle(string model)
        {
            IVehicle vehicle;
            if (model.Equals("CRF450R", StringComparison.OrdinalIgnoreCase))
            {
                vehicle = new HondaMotorcycle("CRF450R");
                Console.WriteLine($"The {FactoryName} factory fires up the {vehicle.Model}'s engine");
                return;
            }
            if (model.Equals("CRF250R", StringComparison.OrdinalIgnoreCase))
            {
                vehicle = new HondaMotorcycle("CRF250R");
                Console.WriteLine($"The {FactoryName} factory fires up the {vehicle.Model}'s engine");
                return;
            }
            if (model.Equals("TypeR", StringComparison.OrdinalIgnoreCase))
            {
                vehicle = new HondaCar("TypeR");
                Console.WriteLine($"The {FactoryName} factory fires up the {vehicle.Model}'s engine");
                return;
            }
            if (model.Equals("Coupe", StringComparison.OrdinalIgnoreCase))
            {
                vehicle = new HondaCar("Coupe");
                Console.WriteLine($"The {FactoryName} factory fires up the {vehicle.Model}'s engine");
                return;
            }
            throw new ArgumentException($"{model} model not found");
        }

        #region Classes
        // Concrete Classes
        public class HondaMotorcycle : Motorcycle, IVehicle
        {
            public string Model { get; set; }
            
            public HondaMotorcycle(string model)
            {
                Model = model;
            }
            public void StartEngine()
            {
                Console.WriteLine($"{Model} prepares to fly on {Wheels} wheels");
            }
        }
        public class HondaCar : Car, IVehicle
        {
            public string Model { get; set; }

            public HondaCar(string model)
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
