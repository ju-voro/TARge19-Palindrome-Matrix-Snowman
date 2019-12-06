using System;

namespace SnowManProject
{
    //build a snowman
    //snowman has got a name and mass (int mass = 10)
    //snowman melts if temperature is higher than 0 and loses 20% of his mass
    //snowman stands outside for 3 days
    //the temperature outside fluctates from -5 to +10
    //display the final mass of the snowman after three days of being outside

    class Program
    {
        static void Main(string[] args)
        {
            Snowman snowman = new Snowman("Olaf");

            Console.WriteLine($"Hello, I'm {snowman.Name}");
            Random rnd = new Random();

            for(int i = 0; i<3; i++)
            {
                int temperature = rnd.Next(-5, 11);
                Console.WriteLine($"It's {temperature} degree today.");
                snowman.Melt(temperature);
            }

            Console.WriteLine($"The mass of the snowman after three days: {snowman.Mass}");

            Console.ReadLine();
        }
    }
}
