using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalsShould
    {
        private Animal _animal;
        private Dog _dog;

        public AnimalsShould(){
            _animal = new Animal();
            _dog = new Dog();

        }

        [Fact]
        public void SetName()
        {
            _dog.SetName("dog");

            Assert.Equal(_dog.Name, "dog");
        }
        [Fact]
        public void SetSpecies()
        {
            _dog.SetSpecies("mutt");

            Assert.Equal(_dog.Species, "mutt");
        }
        public void Walk()
        {
            _dog.Walk(2, 10);

            Assert.Equal(_dog.Speed, 2.5);
        }
    }
}
