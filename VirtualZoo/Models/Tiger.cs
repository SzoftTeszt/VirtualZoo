﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualZoo.Models
{
    public class Tiger : Animal
    {
        public Tiger(string name, int age, string zoneName) : base(name, age, "tiger", zoneName)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} uvolt: Grr-grr");
        }

    }
}
