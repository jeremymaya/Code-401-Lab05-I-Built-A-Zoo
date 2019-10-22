using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    public class Bear : Mammal
    {
        public string Color { get; set; }
        public override string Species { get; set; }
        public override string Reproduce { get; set; }

        public Bear(string species, bool extinct, string reproduce, bool fur, string color) : base(species, extinct, reproduce, fur)
        {
            Color = color;
        }

        public override void Eat()
        {
            Console.WriteLine("I am omnivorous");
        }

        public override void Hibernate()
        {
            Console.WriteLine("I hibernate during winter");
        }

        public override string Sound()
        {
            return "I go RAWR";
        }

        public override void Hunt()
        {
            Console.WriteLine("I has salmon cookie");
        }
    }
}
