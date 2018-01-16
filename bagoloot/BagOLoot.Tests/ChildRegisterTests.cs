using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class ChildShould
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

    }
}
