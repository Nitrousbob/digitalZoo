namespace DigitalZooP1
{
    internal class DisplayInfo
    {
        public DisplayInfo() { }

        public static void Display(Animal animal)  //needs to accept an Animal object as a parameter
        {
            DisplayAnimalInfo(animal);  //uses the animal object to call the DisplayAnimalInfo method
            DisplayAnimalAbilities(animal);  //uses the animal object to call the DisplayAnimalAbilities method
        }


        public static void DisplayAnimalInfo(Animal animal)
        {
            Console.WriteLine($"The animal is a {animal.GetType().Name} and its name is {animal.Name} and has {animal.NumberOfLegs} legs.");
        }

        public static void DisplayEnclosureInfo(Enclosure enclosure)
        {
            Console.WriteLine($"The enclosure is a {enclosure.Name} enclosure.");
        }

        public static void DisplayAnimalAbilities(Animal animal)
        {
            if (animal is ICanFly flyingAnimal)
            {
                flyingAnimal.Fly();
            }
            else
            {
                Console.WriteLine($"{animal.Name} cannot fly.");
            }

            if (animal is ICanBurrow burrowingAnimal)
            {
                burrowingAnimal.Burrow();
            }
            else
            {
                Console.WriteLine($"{animal.Name} cannot burrow.");
            }

            if (animal is ICanSwim swimmingAnimal)
            {
                swimmingAnimal.Swim();
            }
            else
            {
                Console.WriteLine($"{animal.Name} cannot swim.");
            }
        }
    }
}
