using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualZoo.Models
{

    public class Bat : Animal
    {
        public Bat(string name, int age, string zoneName) 
            : base(name, age, "Denevér", zoneName)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} vinnyog: Vinny-vinny!");
        }
    }
}
