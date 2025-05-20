using System;

namespace VirtualZoo.Models
{
    public class Elephant : Animal
    {
        public Elephant(string name, int age, string zoneName)
            : base(name, age, "Elefánt", zoneName)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} trombitál: Trrr!");
        }
    }
}