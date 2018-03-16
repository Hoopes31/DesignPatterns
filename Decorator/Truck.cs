using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Truck
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public abstract double GetPrice();
        public abstract string GetDescription();
    }
}
