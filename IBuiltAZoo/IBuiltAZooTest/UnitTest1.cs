using IBuiltAZoo.Classes;
using System;
using Xunit;

namespace IBuiltAZooTest
{
    public class UnitTest1
    {
        [Fact]
        public void BearOne()
        {
            Bear polarBear = new Bear("Polar Bear", false, "Birth", true, "White");
            Assert.False(polarBear.Extinct);
        }
        [Fact]
        public void BearTwo()
        {
            Bear polarBear = new Bear("Polar Bear", false, "Birth", true, "White");
            Assert.Equal("I go RAWR", polarBear.Sound());
        }
        [Fact]
        public void TigerOne()
        {
            Tiger siberianTiger = new Tiger("Siberian Tiger", false, "Birth", true, "Siberia");
            Assert.False(siberianTiger.Extinct);
        }
        [Fact]
        public void TigerTwo()
        {
            Tiger siberianTiger = new Tiger("Siberian Tiger", false, "Birth", true, "Siberia");
            Assert.Equal("I go PURRRR", siberianTiger.Sound());
        }
        [Fact]
        public void ElephantOne()
        {
            Elephant elephant = new Elephant("Dumbo", false, "Birth", true, 2);
            Assert.Equal("Dumbo", elephant.Species);
        }
        [Fact]
        public void ElephantTwo()
        {
            Elephant elephant = new Elephant("Dumbo", false, "Birth", true, 2);
            Assert.Equal("I go weeeeeeee", elephant.Sound());
        }
        [Fact]
        public void DinosaurOne()
        {
            Dinosaur tRex = new Dinosaur("T-Rex", true, "Egg", true, "Other dinosaur");
            Assert.True(tRex.Extinct);
        }
        [Fact]
        public void DinosaurTwo()
        {
            Dinosaur tRex = new Dinosaur("T-Rex", true, "Egg", false, "Other dinosaur");
            Assert.Equal("T-Rex", tRex.Species);
        }
        public void BirdOne()
        {
            Bird ostrich = new Bird("Ostrich", false, "Egg", false, "Hmm");
            Assert.Equal("I can't fly but I can run", ostrich.Fly(true));
        }
        [Fact]
        public void BirdTwo()
        {
            Bird ostrich = new Bird("Ostrich", false, "Egg", true, "Hmm");
            Assert.False(ostrich.Extinct);
        }
    }
}
