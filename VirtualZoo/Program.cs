using System;
using VirtualZoo.Models;
using VirtualZoo.Services;

namespace VirtualZoo
{
    class Program
    {
        //static IAnimalManager manager = new AnimalManager();

        static void Main(string[] args)
        {
            var denever = new Bat("Rezső", 5, "Barlang");

            Console.WriteLine(denever);

            var eger = new Eger("Ernő", 5, "Kamra");
            Console.WriteLine(denever.Age>4?"Vén dög!":"Kis pocok!");
            Console.WriteLine(eger);


            var hangya = new Hangya("Eri", 4, "Homok");
            Console.WriteLine(hangya);

            Console.WriteLine(denever.Age>4?"Vén dög!":"Kis pocok!");

            var delfin = new Delfin("Dodi", 1, "ViziVilág");
            Console.WriteLine(delfin);
            Console.WriteLine(delfin.Age < 2 ? "Állatkerti medence" : "Még mehet a tengerbe");

            var vidra = new Otter("Áspis", 2, "Tavak");
            Console.WriteLine(vidra);
            Console.WriteLine(vidra.Age > 2 ? "Selyem bubó!" : "Nyammogi!");

            var cica = new Cat("Jockey", 4, "Kert");
            Console.WriteLine(cica);
            Console.WriteLine(cica.Age > 4 ? "Kandúrbandi!" : "Suhanc!");


            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //ConsoleKeyInfo input = new ConsoleKeyInfo();


            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //ConsoleKeyInfo input = new ConsoleKeyInfo();

            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("\n--- VIRTUÁLIS ÁLLATKERT MENÜ ---\n");
            //    Console.WriteLine("1 - Új állat hozzáadása");
            //    Console.WriteLine("2 - Állatok listázása");
            //    Console.WriteLine("3 - Állatok listázása zónánként");
            //    Console.WriteLine("4 - Állat etetése");
            //    Console.WriteLine("5 - Állat mozgatása");
            //    Console.WriteLine("6 - Állat törlése");
            //    Console.WriteLine("0 - Kilépés\n");

            //    switch (input.KeyChar)
            //    {
            //        case '1': AddAnimal(); break;
            //        case '2': ListAnimals(); break;
            //        case '3': ListByZone(); break;
            //        case '4': FeedAnimal(); break;
            //        case '5': MoveAnimal(); break;
            //        case '6': RemoveAnimal(); break;
            //        case '0': return;
            //        default:  break;
            //    }
            //    input = Console.ReadKey(true);
            //}
        }

        static void AddAnimal()
        {
            //Console.Write("Állat neve: ");
            //var name = Console.ReadLine();

            //Console.Write("Kora (év): ");
            //if (!int.TryParse(Console.ReadLine(), out int age))
            //{
            //    Console.WriteLine("Érvénytelen kor.");
            //    return;
            //}

            //Console.Write("Zóna neve: ");
            //var zone = Console.ReadLine();

            //Console.WriteLine("Faj kiválasztása: [lion / elephant / penguin]");
            //var species = Console.ReadLine()?.ToLower();

            //Animal animal = species switch
            //{
            //    "lion" => new Lion(name, age, zone),
            //    "elephant" => new Elephant(name, age, zone),
            //    "penguin" => new Penguin(name, age, zone),
            //    _ => null
            //};

            //if (animal == null)
            //{
            //    Console.WriteLine("Ismeretlen faj.");
            //    return;
            //}

            //manager.AddAnimal(animal);
        }

        static void ListAnimals()
        {
            //var animals = manager.GetAllAnimals();
            //if (animals.Count == 0)
            //{
            //    Console.WriteLine("Nincsenek állatok.");
            //    return;
            //}

            //foreach (var a in animals)
            //    Console.WriteLine(a);
        }

        static void ListByZone()
        {
            //Console.Write("Zóna neve: ");
            //var zone = Console.ReadLine();
            //var animals = manager.GetAnimalsByZone(zone);

            //if (animals.Count == 0)
            //{
            //    Console.WriteLine("Nincs állat ebben a zónában.");
            //    return;
            //}

            //foreach (var a in animals)
            //    Console.WriteLine(a);
        }

        static void FeedAnimal()
        {
            //Console.Write("Állat neve: ");
            //var name = Console.ReadLine();
            //manager.FeedAnimal(name);
        }

        static void MoveAnimal()
        {
            //Console.Write("Állat neve: ");
            //var name = Console.ReadLine();

            //Console.Write("Új zóna neve: ");
            //var newZone = Console.ReadLine();

            //manager.MoveAnimal(name, newZone);
        }

        static void RemoveAnimal()
        {
            //Console.Write("Állat neve: ");
            //var name = Console.ReadLine();
            //manager.RemoveAnimal(name);
        }
    }
}