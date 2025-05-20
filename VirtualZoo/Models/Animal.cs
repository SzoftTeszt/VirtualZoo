using System;

namespace VirtualZoo.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; protected set; }
        public bool IsHungry { get; protected set; } = true;
        public string ZoneName { get; set; }

        protected Animal(string name, int age, string species, string zoneName)
        {
            Name = name;
            Age = age;
            Species = species;
            ZoneName = zoneName;
        }

        public abstract void MakeSound();

        public virtual void Feed()
        {
            if (IsHungry)
            {
                Console.WriteLine($"\"{Name}\" ({Species}) megetetve.");
                IsHungry = false;
            }
            else
            {
                Console.WriteLine($"{Name} nem éhes.");
            }
        }

        public virtual void MoveTo(string newZone)
        {
            Console.WriteLine($"{Name} áthelyezve innen: {ZoneName} ide: {newZone}.");
            ZoneName = newZone;
        }

        public override string ToString()
        {
            return $"{Species} - Név: {Name}, Kor: {Age}, Zóna: {ZoneName}, Éhes: {(IsHungry ? "Igen" : "Nem")}";
        }
    }
}