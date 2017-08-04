using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class ToyRegisterShould
    {
        private readonly SantasToyBag _register;
        private readonly SantasNiceList _book;

        public ToyRegisterShould()
        {
            _register = new SantasToyBag();
            _book = new SantasNiceList();
        }

        [Fact]
        public void AddToy()
        {
            // Create a child
            Child kid = _book.AddChild("Terell");

            // Add a toy for the child
            Toy toy = _register.Add("Silly Putty", kid);
            Assert.True(toy != null);
        }

        [Fact]
        public void RevokeToyFromChild()
        {
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
