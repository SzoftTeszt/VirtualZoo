﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualZoo.Models
{
    public class Hangya : Animal

    {

        public Hangya(string name, int age, string zoneName) : base(name, age, "Hangya", zoneName)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} nyammog: Nyamm-nyam!");
        }
    }
}
