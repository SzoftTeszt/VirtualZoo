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

        public void FeedAnimal(string name) {
            var animal = this.GetAnimalByName(name);
            animal.Feed();
        }
        public void MoveAnimal(string name, string newZone) {
            var animal = this.GetAnimalByName(name);
            animal.ZoneName = newZone;
        }
        public Animal GetAnimalByName(string name) {
            return animals.FirstOrDefault(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
        public List<Animal> GetAllAnimals() {
            return animals;
        }
        public List<Animal> GetAnimalsByZone(string zoneName) {
        
            return animals.Where(x=>x.ZoneName.Equals(zoneName, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public void RemoveAnimal(string name) {
            var animal = this.GetAnimalByName(name);
            animals.Remove(animal);
        }

    }
}
