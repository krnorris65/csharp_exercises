using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class BagShould
    {
        [Fact]
        public void AddChildToRegister()
        {
            Child suzie = new Child(){
                FirstName = "Suzie",
                LastName = "McDonell",
                Address = "346 Underdog Way"
            };

            ChildRegister childRegister = new ChildRegister();
            childRegister.AddChild(suzie);

            Assert.Contains(suzie, childRegister.GetRegister());
        }

        [Fact]
        public void AddPresent()
        {

            Child bobby = new Child();
            bobby.FirstName= "Bobby";
            bobby.LastName = "Tables";
            bobby.Address = "1000 Infinity Loop";

            Present bike = new Present("Bike", bobby);

            Bag bag = new Bag();
            bag.AddPresent(bike);

            Assert.Contains(bike, bag.GetContents());
        }

        [Fact]
        public void RemovePresent()
        {

            Child bobby = new Child();
            bobby.FirstName= "Bobby";
            bobby.LastName = "Tables";
            bobby.Address = "1000 Infinity Loop";

            Present bike = new Present("Bike", bobby);

            Bag bag = new Bag();
            bag.AddPresent(bike);
            bag.RemovePresent(bike);

            Assert.DoesNotContain(bike, bag.GetContents());
        }

        [Fact]
        public void DeliverPresent()
        {

            Child bobby = new Child();
            bobby.FirstName= "Bobby";
            bobby.LastName = "Tables";
            bobby.Address = "1000 Infinity Loop";

            Present bike = new Present("Bike", bobby);

            Bag bag = new Bag();
            bag.AddPresent(bike);
            bag.DeliverPresent(bike);

            Assert.True(bike.Delivered);
            Assert.DoesNotContain(bike, bag.GetContents());
        }


    }
}
