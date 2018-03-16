using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class TruckDecorator : Truck
    {
        // Protect this so it can't be modified by non-truck objects
        protected Truck _truck;

        // Take in truck so we can modify it
        public TruckDecorator(Truck truck)
        {
            _truck = truck;
        }

        // When GetDescription is called get the description on this instance truck
        public override string GetDescription() => _truck.GetDescription();

        // When GetPrice is called get the price on this instance of truck
        public override double GetPrice() => _truck.GetPrice();
    }
}
