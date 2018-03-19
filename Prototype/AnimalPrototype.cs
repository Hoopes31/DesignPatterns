using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class AnimalPrototype : Cloneable
    {
        public int LegCount;
        public string Name;

        public AnimalPrototype (int legCount, string name)
        {
            LegCount = legCount;
            Name = name;
        }

        public override Cloneable Clone()
        {
            Console.WriteLine($"Cloning {LegCount} legged, {Name}");
            var clone = MemberwiseClone() as AnimalPrototype;
            clone.LegCount = UpdateLegs();
            clone.Name = clone.Name + "_2";
            return clone;
        }

        public int UpdateLegs()
        {
            return LegCount + 2;
        }
    }
}
