namespace DigitalZooP1
{
    internal class Jorntoggler : Animal , ICanSwim, ICanBurrow
    {
        public Jorntoggler(string name, int numberOfEyes, int numberOfLegs, string favoriteFood) : base(name, numberOfEyes, numberOfLegs, favoriteFood)
        {
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming gracefully in the water.");
        }

        public void Burrow()
        {
            Console.WriteLine($"{Name} burrows into the ground!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes a clicking and tapping sound.");
        }

    }
}
