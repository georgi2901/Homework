using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Racer
    {
        public Automobile Automobile { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int Points { get; set; }

        public Racer(string name, double horsePowers, string boost)
        {
            Name = name;
            Automobile = new Automobile(horsePowers, boost);
        }

        public override string ToString()
        {
            return Name + " " + Points;
        }
    }
}
