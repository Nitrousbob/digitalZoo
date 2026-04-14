namespace DigitalZooP1
{
    internal class Animal
    {
        private string _name;
        public int NumberOfEyes { get; private set; }
        public int NumberOfLegs { get; private set; }
        public string FavoriteFood { get; private set; }

        public string Name { get { return _name; } set { _name = value; } }

        public Animal(string name, int numberOfEyes, int numberOfLegs, string favoriteFood) 
        {
            _name = name;
            NumberOfEyes = numberOfEyes;
            NumberOfLegs = numberOfLegs;
            FavoriteFood = favoriteFood;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{_name} makes noises that are unique to its species.");
        }
    }
}
