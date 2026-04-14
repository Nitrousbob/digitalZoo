using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalZooP1
{
    internal class Human
    {
        public string name { get; private set;  }

        public Human(string name)
        {
            this.name = name;
        }

        public void Look(Animal animal)
        {
            Console.WriteLine($"{name} is looking at {animal.Name} the {animal.GetType().Name}.");
        }

        public void Move(Enclosure enclosure)
        {
            Console.WriteLine($"{name} is moving to the {enclosure.Name} enclosure.");
        }
    }
}
