using dojo;
using System;
using Xunit;

namespace DataStructureTests
{
    public class GenericQueueTests
    {
        [Fact]
        public void QueueStartsOffEmpty()
        {
            var queue = new GenericQueueFromLinkedListImplementation<int>();

            Assert.Equal(0, queue.Count);
        }

        [Fact]
        public void QueueStartsOffWithOneItem()
        {
            var queue = new GenericQueueFromLinkedListImplementation<int>(new Node<int>(8));

            Assert.Equal(1, queue.Count);
        }

        [Fact]
        public void CanPeekIntoQueueToSeeNextItemToDeque()
        {
            var queue = new GenericQueueFromLinkedListImplementation<int>(new Node<int>(8));


            Assert.Equal(8, queue.Peek.Value);
        }

        [Fact]
        public void QueueDequeuesCorrectly()
        {
            var queue = new GenericQueueFromLinkedListImplementation<int>(new Node<int>(8));
            queue.Enqueue(9);
            queue.Enqueue(19);

            Assert.Equal(8, queue.Dequeue().Value);
        }

        [Fact]
        public void QueueThrowsArgumentExceptionWhenDequeuingFromAnEmptyQueue()
        {
            var queue = new GenericQueueFromLinkedListImplementation<int>();

            Assert.Throws<ArgumentException>(() => queue.Dequeue());
        }

        [Fact]
        public void QueueEnqueuesCorrectly()
        {
            var queue = new GenericQueueFromLinkedListImplementation<int>();

            queue.Enqueue(8);
            queue.Enqueue(new Node<int>(20));

            Assert.Equal(2, queue.Count);
        }

        [Fact]
        public void QueueReturnsNullIfPeekingIntoAnEmptyQueue()
        {
            var queue = new GenericQueueFromLinkedListImplementation<int>();

            Assert.Null(queue.Peek);
        }
    }
}
