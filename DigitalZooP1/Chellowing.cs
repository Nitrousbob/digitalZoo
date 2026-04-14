namespace DigitalZooP1
{
    internal class Chellowing : Animal , ICanFly
    {

        public Chellowing(string name, int numberOfEyes, int numberOfLegs, string favoriteFood) : base(name, numberOfEyes, numberOfLegs, favoriteFood)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes a long low hum.");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying!");
        }

        
    }
}
