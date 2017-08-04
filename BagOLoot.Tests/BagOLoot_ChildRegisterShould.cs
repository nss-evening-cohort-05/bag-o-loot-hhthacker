using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class ChildRegisterShould
    {
        private readonly SantasNiceList _register;

        public ChildRegisterShould()
        {
            _register = new SantasNiceList();
        }

        [Theory]
        [InlineData("Sarah")]
        [InlineData("Jamal")]
        [InlineData("Kelly")]
        public void AddChildren(string child)
        {
            var result = _register.AddChild(child);
            Assert.True(result != null);
        }

        [Fact]
        public void ReturnListOfChildren()
        {
            _register.AddChild("Svetlana");
            List<Child> children = _register.GetChildren();
            Assert.IsType<List<Child>>(children);
            Assert.True(children.Count > 0);
        }

        [Fact]
        public void GetAChild()
        {
            var created = _register.AddChild("Svetlana");
            Child svetlana = _register.GetChild("Svetlana");
            Assert.True(created.name == svetlana.name);
        }
    }
}
