using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MonsterTruck : Truck
    {
        public MonsterTruck()
        {
            Description = "Monster Truck";
        }

        // Returns Description when GetDescription is called
        public override string GetDescription() => Description;

        // Returns 100000.00 when GetPrice is called
        public override double GetPrice() => 100000.00;
    }
}
