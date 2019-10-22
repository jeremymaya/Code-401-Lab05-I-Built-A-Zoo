using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    public class Elephant : Mammal
    {
        public int Tusk { get; set; }
        public override string Species { get; set; }
        public override string Reproduce { get; set; }

        public Elephant(string species, bool extinct, string reproduce, bool fur, int tusk) : base(species, extinct, reproduce, fur)
        {
            Tusk = tusk;
        }

        public override void Eat()
        {
            Console.WriteLine("I am a herbivore");
        }

        public override void Hibernate()
        {
            Console.WriteLine("What is winter?");
        }

        public override void Hunt()
        {
            Console.WriteLine("I HUNT");
        }
    }
}
