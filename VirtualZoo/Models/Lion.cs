using System;

namespace VirtualZoo.Models
{
    public class Lion : Animal
    {
        public Lion(string name, int age, string zoneName)
            : base(name, age, "Oroszlán", zoneName)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} ordít: Rrrr!");
        }
    }
}