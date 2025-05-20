using System;

namespace VirtualZoo.Models
{
    public class Penguin : Animal
    {
        public Penguin(string name, int age, string zoneName)
            : base(name, age, "Pingvin", zoneName)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} csipog: Pííí!");
        }
    }
}