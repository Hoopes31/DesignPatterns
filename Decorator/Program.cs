using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explicit declaration is required here
            Truck monsterTruck = new MonsterTruck();
            Console.WriteLine(monsterTruck.GetDescription());
            Console.WriteLine(monsterTruck.GetPrice());

            monsterTruck = new BiggerWheels(monsterTruck);
            Console.WriteLine(monsterTruck.GetDescription());
            Console.WriteLine(monsterTruck.GetPrice());
        }
    }
}
