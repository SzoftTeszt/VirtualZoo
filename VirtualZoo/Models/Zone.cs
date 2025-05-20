using System.Collections.Generic;

namespace VirtualZoo.Models
{
    public class Zone
    {
        public string Name { get; set; }
        public List<Animal> Residents { get; set; }

        public Zone(string name)
        {
            Name = name;
            Residents = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            Residents.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            Residents.Remove(animal);
        }

        public override string ToString()
        {
            return $"Zóna: {Name}, Állatok száma: {Residents.Count}";
        }
    }
}