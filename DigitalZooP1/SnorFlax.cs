namespace DigitalZooP1
{
    internal class SnorFlax : Animal , ICanSwim
    {
        public SnorFlax(string name, int numberOfEyes, int numberOfLegs, string favoriteFood) : base(name, numberOfEyes, numberOfLegs, favoriteFood)
        {
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming gracefully in the water.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes a snoring type sound.");
        }
    }
}
