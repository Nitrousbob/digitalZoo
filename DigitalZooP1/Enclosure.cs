using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalZooP1
{
    internal class Enclosure
    {
        public string Name { get; private set; }
        private List<Animal> animals;
        public bool HasWater { get; private set; } = false;

        public Enclosure(string name, bool hasWater = false)
        {
            Name = name;
            animals = new List<Animal>();
            HasWater = hasWater;
        }

        public void AddAnimal(Animal animal)  //adds an animal to the enclosure by taking an Animal object as a parameter and adding it to the list of animals in the enclosure
        {
            animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }

        public void DisplayAnimals(Human h)  //takes a human object as a parameter and uses it to call the Look method for each animal in the enclosure
        {
            foreach (var animal in animals)  //iterates through the list of animals in the enclosure
            {
                h.Look(animal);  //tells the human to look at each animal in the enclosure

                if (animal is ICanSwim && HasWater)
                {
                    Console.WriteLine($"{animal.Name} is swimming in the water.");
                }
                else if (animal is ICanFly)
                {
                    Console.WriteLine($"{animal.Name} is flying around.");
                }
                else if (animal is ICanBurrow)
                {
                    Console.WriteLine($"{animal.Name} is burrowing.");
                }
            }


        }
    }
}
