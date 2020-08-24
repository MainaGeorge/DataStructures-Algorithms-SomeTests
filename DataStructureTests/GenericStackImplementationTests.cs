using System;
using dojo;
using Xunit;

namespace DataStructureTests
{
    public class GenericStackImplementationTests
    {
        [Fact]
        public void StackStartsOffEmpty()
        {
            var stack = new GenericStackFromLinkedListImplementation<string>();

            Assert.Equal(0, stack.Count);
        }

        [Fact]
        public void StackStartsOffWithOneElement()
        {
            var stack = new GenericStackFromLinkedListImplementation<string>(new Node<string>("home"));

            Assert.Equal(1, stack.Count);
            Assert.Equal("home", stack.Peek.Value);
        }

        [Fact]
        public void StackCanPushElements()
        {
            var stack = new GenericStackFromLinkedListImplementation<string>(new Node<string>("home"));

            stack.Push("neighbor");
            stack.Push("lovely");

            Assert.Equal(3, stack.Count);
        }

        [Fact]
        public void StackCanPeekInToSeeNextElement()
        {
            var stack = new GenericStackFromLinkedListImplementation<string>(new Node<string>("home"));

            stack.Push("added");

            Assert.Equal("added", stack.Peek.Value);
        }

        [Fact]
        public void StackPopsOffTheCorrectElement()
        {
            var stack = new GenericStackFromLinkedListImplementation<string>(new Node<string>("home"));

            stack.Push("name");
            stack.Push("email");

            var popped = stack.Pop.Value;

            Assert.Equal("email", popped);
        }

        [Fact]
        public void StackReturnsNullWhilePeekingEmptyStack()
        {
            var stack = new GenericStackFromLinkedListImplementation<string>();

            Assert.Null(stack.Peek);
        }

        [Fact]
        public void StackThrowsArgumentExceptionWhilePoppingEmptyStack()
        {
            var stack = new GenericStackFromLinkedListImplementation<string>();

            Assert.Throws<ArgumentException>(() => stack.Pop);
        }
    }
}
