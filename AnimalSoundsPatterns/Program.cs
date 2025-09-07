using System;
using System.Collections.Generic;
using AnimalSoundsPatterns.Animals;
using AnimalSoundsPatterns.Factory;

namespace AnimalSoundsPatterns
{
    public static class Program
    {
        private static readonly List<AnimalCreator> Creators = new List<AnimalCreator>
        {
            new DogCreator(), new CatCreator(), new CowCreator(), new DuckCreator()
        };

        public static void Main()
        {
            Console.WriteLine("Animal Sounds (Strategy + Factory Method)");
            Console.WriteLine("Type 'list' to see animals, 'exit' to quit.\n");

            while (true)
            {
                Console.Write("Choose an animal: ");
                var input = (Console.ReadLine() ?? "").Trim();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                if (input.Equals("list", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Known animals: " + string.Join(", ", Creators.ConvertAll(c => c.Type)) + "\n");
                    continue;
                }

                IAnimal animal = null;
                foreach (var c in Creators)
                {
                    if (c.Type.Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        animal = c.Create();
                        break;
                    }
                }

                if (animal == null)
                    Console.WriteLine(input + " is not a known animal.\n");
                else
                    Console.WriteLine(animal.Type + " makes sound: " + animal.Sound + "\n");
            }

            Console.WriteLine("Bye! Press Enter to close...");
            Console.ReadLine();
        }
    }
}
