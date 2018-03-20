using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class SheepPrototype : Cloneable
    {
        public int LegCount;
        public string Name;

        public SheepPrototype (int legCount, string name)
        {
            LegCount = legCount;
            Name = name;
        }

        public override Cloneable Clone()
        {
            Console.WriteLine($"Cloning {LegCount} legged, {Name}");
            var clone = MemberwiseClone() as SheepPrototype;
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
