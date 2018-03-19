using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Save passed clones
            var cloneFarm = new Dictionary<string, AnimalPrototype>();

            // Initialize some clones
            cloneFarm["Animal_1"] = new AnimalPrototype(4, "Betsy");
            cloneFarm["Animal_2"] = new AnimalPrototype(5, "Penta");
            cloneFarm["Animal_3"] = new AnimalPrototype(3, "Accidenta");

            // Clone some animals!
            AnimalPrototype betsyClone = cloneFarm["Animal_1"].Clone() as AnimalPrototype;
            AnimalPrototype ginaClone = cloneFarm["Animal_2"].Clone() as AnimalPrototype;
            AnimalPrototype accidentaClone = cloneFarm["Animal_3"].Clone() as AnimalPrototype;

            // Add clones to the clone farm
            cloneFarm.Add("Animal_4", betsyClone);
            cloneFarm.Add("Animal_5", ginaClone);
            cloneFarm.Add("Animal_6", accidentaClone);

            // Looks like we got some mutations
            Console.WriteLine("\n");
            Console.WriteLine("All the anmials in the clone farm are:");
            foreach (var clone in cloneFarm)
            {
                Console.WriteLine($"{clone.Key} is {clone.Value.LegCount} legged, {clone.Value.Name}");
            }
        }

        
    }
}
