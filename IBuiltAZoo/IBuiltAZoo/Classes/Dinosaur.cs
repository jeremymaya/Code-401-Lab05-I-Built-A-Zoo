﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    class Dinosaur : Reptile
    {
        public string Food { get; set; }
        public override string Species { get; set; }
        public override string Reproduce { get; set; }
     
        public Dinosaur(string species, bool extinct, string reproduce, bool fur, string food) : base(species, extinct, reproduce, fur)
        {
            Food = food;
        }

        public override void Eat()
        {
            Console.WriteLine($"I eat {Food}");
        }

        public override void Fly(bool canFly)
        {
            if (canFly)
            {
                Console.WriteLine("I can flyyy");
            }
            else
            {
                Console.WriteLine("I can't fly but I can either swim or run");
            }
        }
    }
}
