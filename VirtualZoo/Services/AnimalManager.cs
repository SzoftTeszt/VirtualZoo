using System;
using System.Collections.Generic;
using System.Linq;
using VirtualZoo.Models;

namespace VirtualZoo.Services
{
    public class AnimalManager : IAnimalManager
    {
        private List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            if (animals.Any(a => a.Name.Equals(animal.Name, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"Már létezik ilyen nevű állat: '{animal.Name}'.");
                return;
            }

            animals.Add(animal);
            Console.WriteLine($"{animal.Name} nevű állat hozzáadva a(z) {animal.ZoneName} zónához.");
        }

        public void FeedAnimal(string name)
        {
            var animal = GetAnimalByName(name);
            if (animal != null)
            {
                animal.Feed();
            }
            else
            {
                Console.WriteLine($"Nem található ilyen nevű állat: '{name}'.");
            }
        }

        public void MoveAnimal(string name, string newZone)
        {
            var animal = GetAnimalByName(name);
            if (animal != null)
            {
                animal.MoveTo(newZone);
            }
            else
            {
                Console.WriteLine($"Nem található ilyen nevű állat: '{name}'.");
            }
        }

        public Animal GetAnimalByName(string name)
        {
            return animals.FirstOrDefault(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<Animal> GetAllAnimals()
        {
            return new List<Animal>(animals);
        }

        public List<Animal> GetAnimalsByZone(string zoneName)
        {
            return animals
                .Where(a => a.ZoneName.Equals(zoneName, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public void RemoveAnimal(string name)
        {
            var animal = GetAnimalByName(name);
            if (animal != null)
            {
                animals.Remove(animal);
                Console.WriteLine($"{animal.Name} törölve az állatkertből.");
            }
            else
            {
                Console.WriteLine($"Nem található ilyen nevű állat: '{name}'.");
            }
        }
    }
}