using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualZoo.Models
{
    internal class Macska : Animal
    {
        public Macska(string name, int age, string species, string zoneName) : base(name, age, species, zoneName)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} ({Species}) nyávog.");
        }
    }
}
