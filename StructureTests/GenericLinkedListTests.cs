using System;
using dojo;
using Xunit;

namespace StructuresTests
{
    public class GenericLinkedListTests
    {
        [Fact]
        public void ListStartsOffEmpty()
        {
            var linkedList = new GenericLinkedListImplementation<string>();

            Assert.Equal(0, linkedList.Length);
        }

        [Fact]
        public void ListStartsWithAHeadNode()
        {
            var linkedList = new GenericLinkedListImplementation<string>(new Node<string>("father"));

            Assert.Equal(1, linkedList.Length);
            Assert.Equal("father", linkedList.GetFirst.Value);
        }

        [Fact]
        public void ListAddElementsCorrectly()
        {
            var linkedList = new GenericLinkedListImplementation<string>();

            linkedList.AddNode("mother");
            linkedList.AddNode("father");
            linkedList.AddNode("son");

            Assert.Equal(3, linkedList.Length);
        }

        [Fact]
        public void ListAddsElementsAtTheBeginning()
        {
            var linkedList = new GenericLinkedListImplementation<string>();

            linkedList.AddNode("mother");
            linkedList.AddNode("father");
            linkedList.AddNode("son");
            linkedList.AddFirst("sister");

            Assert.Equal("sister", linkedList.GetFirst.Value);
        }

        [Fact]
        public void ListAddsElementAtTheEnd()
        {
            var linkedList = new GenericLinkedListImplementation<string>();

            linkedList.AddNode("mother");
            linkedList.AddNode("father");
            linkedList.AddNode("son");

            linkedList.AddLast("last element");

            Assert.Equal("last element", linkedList.GetLast.Value);
        }

        [Fact]
        public void ListRemovesFirstElement()
        {
            var linkedList = new GenericLinkedListImplementation<string>();

            linkedList.AddNode("mother");
            linkedList.AddNode("father");
            linkedList.AddNode("son");

            linkedList.RemoveFirst();
            Assert.Equal("father", linkedList.GetFirst.Value);
        }

        [Fact]
        public void ListRemovesLastElement()
        {
            var linkedList = new GenericLinkedListImplementation<string>();

            linkedList.AddNode("mother");
            linkedList.AddNode("father");
            linkedList.AddNode("son");

            linkedList.RemoveLast();

            Assert.Equal("father", linkedList.GetLast.Value);

        }

        [Fact]
        public void ListRemovesAtASpecificIndex()
        {
            var linkedList = new GenericLinkedListImplementation<string>();

            linkedList.AddNode("mother");
            linkedList.AddNode("father");
            linkedList.AddNode("son");

            linkedList.RemoveAt(1);

            Assert.Equal(2, linkedList.Length);
            Assert.Equal(linkedList.GetLast.Value, linkedList.GetAtIndex(1).Value);
        }

        [Fact]
        public void ListAddsAtASpecificIndex()
        {
            var linkedList = new GenericLinkedListImplementation<string>();

            linkedList.AddNode("mother");
            linkedList.AddNode("father");
            linkedList.AddNode("son");

            linkedList.AddAt(1, "adding at 1");

            Assert.Equal("adding at 1", linkedList.GetAtIndex(1).Value);
        }

        [Fact]
        public void ListThrowsExceptionIfIndexOutOfRangeWhenRemoving()
        {
            var linkedList = new GenericLinkedListImplementation<string>();

            linkedList.AddNode("mother");
            linkedList.AddNode("father");
            linkedList.AddNode("son");

            Assert.Throws<IndexOutOfRangeException>(() => linkedList.RemoveAt(linkedList.Length + 1));
        }
        [Fact]
        public void ListThrowsExceptionIfIndexOutOfRangeWhenAdding()
        {
            var linkedList = new GenericLinkedListImplementation<string>();

            linkedList.AddNode("mother");
            linkedList.AddNode("father");
            linkedList.AddNode("son");

            Assert.Throws<IndexOutOfRangeException>(() => linkedList.AddAt(linkedList.Length + 1, "daughter"));
        }
    }
}
