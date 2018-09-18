using System;
using System.Linq;
using ormsafari.Models;

namespace ormsafari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add Animal, that the user names
            // System.Console.WriteLine("Enter an animal's species to add;");
            // var species = Console.ReadLine();

            // var newanimal = new SeenAnimals{
            //     Species = species
            // };

            // var db = new SafariVacationContext();

            // db.SeenAnimalsTable.Add(newanimal);

            // db.SaveChanges();


            //QUERIES\

            // 1. Get all animals
            // SQL: SELECT * FROM "SeenAnimalsTable";
            // var db = new SafariVacationContext();

            // var animals = db.SeenAnimalsTable;

            // foreach (var animal in animals)
            // {
            //     System.Console.WriteLine($"{animal.Species}");
            // }

            // 2. Update TimesSeen and LocationOfLastSeen
            // var UpdateSeen = db.SeenAnimalsTable.FirstOrDefault(animal => animal.Id == 2);

            // UpdateSeen.CountOfTimesSeen = 2;
            // UpdateSeen.LocationOfLastSeen = "Australia";

            // var UpdateSeen = db.SeenAnimalsTable.FirstOrDefault(animal => animal.Id == 3);

            // UpdateSeen.CountOfTimesSeen = 3;
            // UpdateSeen.LocationOfLastSeen = "Jungle";

            // db.SaveChanges();


            // 3.  Jungle Animals
            // var JungleAnimals = db.SeenAnimalsTable
            // .Where(animal => animal.LocationOfLastSeen == "Jungle");
            // foreach (var animal in JungleAnimals) 
            // {
            // System.Console.WriteLine(value: $"A wild {animal.Species} was spotted in the Jungle");
            // }


            // 4.  Remove Desert Animals
            // var RemoveDesert = db.SeenAnimalsTable.FirstOrDefault(animal => animal.LocationOfLastSeen == "Desert");
            // db.SeenAnimalsTable.Remove(RemoveDesert);
            // db.SaveChanges();


            // 5. Total Times Seen
            // var db = new SafariVacationContext();
            // var animals = db.SeenAnimalsTable;
            // var total = 0;
            // foreach (var animal in animals)
            // {
            // total += animal.CountOfTimesSeen
            // }
            //System.Console.WriteLine($"Total amount of animals seen is {total}");


            // 6. Count times of animals seen where species = Lion, Tiger, Bear

            // var db = new SafariVacationContext();
            // var animals = db.SeenAnimalsTable.Where(animal => animal.Species == "Lion" || animal.Species == "Tiger" || animal.Species == "Bear");
            // var total = 0;
            // foreach (var animal in animals) 
            // {
            //     total += animal.CountOfTimesSeen;
            // }
            // System.Console.WriteLine($"User has seen {total} Lions, Tigers, and Bears, oh my!, on safari trip");



        }
    }
}
