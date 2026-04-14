namespace DigitalZooP1
{

    /* 
     * You need to create a digital zoo! What is that? You're going to create a set of imaginary 
     * creatures to put on display for visitors to view. In this first step, you need to create a 
     * class hierarchy to represent these creatures. You will need at least 5 different kinds of 
     * creatures. What they are called and what behavior they exhibit will be up to you but they
     * should all inherit from at least one base class to share some of that behavior.
     * Be sure to create this as a console application. For this part, the application itself doesn't 
     * need to do anything.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Digital Zoo";
            Console.WriteLine("Welcome to the Digital Zoo!");

            //create some objects to display and interact with
            Human h = new Human("Bear");
            
            Chellowing Jimbo = new Chellowing("Jimbo", 2, 4, "Berries");
            DisplayInfo.Display(Jimbo);
            
            SnorFlax Rhonda = new SnorFlax("Rhonda", 2, 4, "Fish");
            DisplayInfo.Display(Rhonda);
            
            Slungerfloo Todd = new Slungerfloo("Todd", 2, 6, "Insects");
            DisplayInfo.Display(Todd);
            
            Jorntoggler Cliff = new Jorntoggler("Cliff", 2, 8, "Leaves");
            DisplayInfo.Display(Cliff);

            Neelinton Ted = new Neelinton("Ted", 2, 0, "Nectar");
            DisplayInfo.Display(Ted);
            Console.WriteLine();

            //build some enclosures
            Enclosure t = new Enclosure("Tropical", true);
            Enclosure d = new Enclosure("Desert", false);

            h.Move(t);  //have the human move to the enclosure
            DisplayInfo.DisplayEnclosureInfo(t);  //display the enclosure information
            t.AddAnimal(Jimbo);  t.AddAnimal(Ted);//add some animals to the enclosure
            t.AddAnimal(Rhonda); 
            t.DisplayAnimals(h);

            Console.WriteLine();
            h.Move(d);  //have the human move to the enclosure
            DisplayInfo.DisplayEnclosureInfo(d);
            d.AddAnimal(Todd); d.AddAnimal(Cliff);
            d.DisplayAnimals(h);


        }
    }
}
