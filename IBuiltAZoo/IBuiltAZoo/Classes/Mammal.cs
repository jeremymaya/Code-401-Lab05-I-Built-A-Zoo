using System;
namespace IBuiltAZoo.Classes
{
    public abstract class Mammal : Animal
    {
        public bool HasFur { get; set; }
        public virtual bool Lactate { get; set; } = true;
        public Mammal(string species, bool extinct, string reproduce, bool fur) : base(species, extinct, reproduce)
        {
            HasFur = fur;
        }

        abstract public void Hibernate();
        public virtual void Hunt()
        {
            Console.WriteLine("Where is my food?");
        }
    }
}
