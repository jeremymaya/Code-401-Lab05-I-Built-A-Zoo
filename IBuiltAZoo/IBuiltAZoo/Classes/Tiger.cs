using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    class Tiger : Mammal
    {
            {
        public string Color { get; set; }
        public override string Species { get; set; }
        public override string Reproduce { get; set; }

        public Tiger(string species, bool extinct, string reproduce, bool fur, string color) : base(species, extinct, reproduce, fur)
        {
            Color = color;
        }

        public override void Eat()
        {
            Console.WriteLine("I am a carnivore");
        }

        public override void Sleep()
        {
            Console.WriteLine("I hibernate during the winter");
        }

        public override void Sound()
        {
            Console.WriteLine("I go RAWR");
        }

        public override void Hunt()
        {
            Console.WriteLine("I has salmon cookie");
        }
    }
}
}
