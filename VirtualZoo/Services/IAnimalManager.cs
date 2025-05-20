using System.Collections.Generic;
using VirtualZoo.Models;

namespace VirtualZoo.Services
{
    public interface IAnimalManager
    {
        void AddAnimal(Animal animal);
        void FeedAnimal(string name);
        void MoveAnimal(string name, string newZone);
        Animal GetAnimalByName(string name);
        List<Animal> GetAllAnimals();
        List<Animal> GetAnimalsByZone(string zoneName);
        void RemoveAnimal(string name);
    }
}