using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class ToyRegisterShould
    {

        [Fact]
        public void AddToy()
        {
            var _register = new ToyRegister();
            var _book = new ChildRegister();
            // Create a child
            Child kid = _book.AddChild("Terell");

            // Add a toy for the child
            Toy toy = _register.Add("Silly Putty", kid);
            Assert.True(toy != null);
        }

        [Fact]
        public void RevokeToyFromChild()
        {
            var _register = new ToyRegister();
            var _book = new ChildRegister();
            //arrange
            Child kid = _book.AddChild("Terell");
            Toy toy = _register.Add("Silly Putty", kid);

            //act
            _register.RevokeToy(toy);
            List<Toy> toysForTerell = _register.GetToysForChild(kid);

            //assert
            Assert.DoesNotContain(toy, toysForTerell);

        }
    }
}
