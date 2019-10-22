using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    class Reptile : Animal
    {
        public bool HasScale { get; set; }
        public virtual bool Egg { get; set; } = true;
        public Reptile(string species, bool extinct, string reproduce, bool scale) : base(species, extinct, reproduce)
        {
            HasScale = scale;
        }

        abstract public void Fly();
        public virtual void Hunt()
        {
            Console.WriteLine("Where is my food?");
        }
    }
}
