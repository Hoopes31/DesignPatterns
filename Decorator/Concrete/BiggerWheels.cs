using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BiggerWheels : TruckDecorator
    {
        // Builds on the base truck class
        public BiggerWheels(Truck truck) : base(truck)
        {
            Description = "Bigger Wheels";
        }

        // Grabs and updates the base class' description by way of the truck class
        public override string GetDescription() => $"{_truck.GetDescription()}, {Description}";

        // Grabs and updates the base class' price by way of the truck class
        public override double GetPrice() => _truck.GetPrice() + 5000.00;
    }
}
