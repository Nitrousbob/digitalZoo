namespace DigitalZooP1
{
    internal class Slungerfloo : Animal , ICanBurrow
    {
        public Slungerfloo(string name, int numberOfEyes, int numberOfLegs, string favoriteFood) : base(name, numberOfEyes, numberOfLegs, favoriteFood)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes a slurping sound.");
        }

        public void Burrow()
        {
            Console.WriteLine($"{Name} is burrowing into the ground!");
        }
    }
}
