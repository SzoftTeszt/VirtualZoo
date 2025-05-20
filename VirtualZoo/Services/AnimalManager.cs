using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualZoo.Models;

namespace VirtualZoo.Services
{
    public class AnimalManager : IAnimalManager
    {
        private List<Animal> animals = new List<Animal>();
        public void AddAnimal(Animal animal) { 
            animals.Add(animal);
        }

        public void FeedAnimal(string name) { }
        public void MoveAnimal(string name, string newZone) { }
        public Animal GetAnimalByName(string name) {
            return new Eger("Ernő", 5, "Kamra");
        }
        public List<Animal> GetAllAnimals() {
            return animals;
        }
        public List<Animal> GetAnimalsByZone(string zoneName) {
        
            return new List<Animal>();
        }
        public void RemoveAnimal(string name) { }

    }
}
