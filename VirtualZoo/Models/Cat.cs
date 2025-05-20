using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualZoo.Models
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string zoneName) : base(name, age, "Szisza", zoneName)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} nyávog: Nyávog!");
        }
    }
}
