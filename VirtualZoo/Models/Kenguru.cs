using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualZoo.Models
{
    public class Kenguru : Animal //mindent örököl az Animal-tól
    {
        public Kenguru(string name, int age, string species, string zoneName) : base(name, age, species, zoneName)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} morog: vau-vau");
        }
    }
}
