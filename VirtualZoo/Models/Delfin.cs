using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualZoo.Models
{

    
    public class Delfin : Animal //örököl minden animátort 
    {
        public Delfin(string name, int age, string zoneName) : base(name, age, "Delfin", zoneName)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} kattog: Ekk-ekk");
        }
    }
}
