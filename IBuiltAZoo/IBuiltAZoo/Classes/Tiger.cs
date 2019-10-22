using System;
using System.Collections.Generic;
using System.Text;
using IBuiltAZoo.Interfaces;

namespace IBuiltAZoo.Classes
{
    public class Tiger : Mammal, ISwim
    {
        public string Region { get; set; }
        public override string Species { get; set; }
        public override string Reproduce { get; set; }

        public Tiger(string species, bool extinct, string reproduce, bool fur, string region) : base(species, extinct, reproduce, fur)
        {
            Region = region;
        }

        public override void Eat()
        {
            Console.WriteLine("I am a carnivore");
        }

        public override void Hibernate()
        {
            Console.WriteLine("I do NOT hibernate during winter");
        }

        public override string Sound()
        {
            return "I go PURRRR";
        }

        public override void Hunt()
        {
            Console.WriteLine("I HUNT");
        }

        public string Swim()
        {
            return "I may be a cat but I swimmm";
        }
    }
}
