using System;
using System.Collections.Generic;
using System.Text;

namespace SnowManProject
{
    class Snowman
    {
        string name;
        double mass = 10;

        public Snowman(string _name)
        {
            name = _name;
        }

        public string Name
        {
            get { return name; }
        }

        public double Mass
        {
            get { return mass; }
        }

        public void Melt(int temperature)
        {
            if (temperature >= 0)
            {
                //mass = mass - (mass * 0.2);
                mass -= mass * 0.2;
                Console.WriteLine("Help! I'm melting!");
            }
        }

    }
}
