﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualZoo.Models
{
    public class Otter : Animal
    {
        public Otter(string name, int age, string zoneName) : base(name, age, "Vidra", zoneName)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} nyekereg: Nyek-Nyeeek!");
        }
    }
}
