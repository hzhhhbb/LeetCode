using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class MyCircularQueueTests
    {
        private MyCircularQueue circularQueue = null;

        [Order(1)]
        [Test()]
        public void MyCircularQueueTest()
        {
            this.circularQueue = new MyCircularQueue(6);
            Assert.True(this.circularQueue != null);
        }

        [Order(2)]
        [Test()]
        public void EnQueueTest()
        {
            Assert.AreEqual(true, this.circularQueue.EnQueue(6));
        }

        [Order(3)]
        [Test()]
        public void DeQueueTest()
        {
            Assert.AreEqual(true, circularQueue.DeQueue());
        }

        [Order(4)]
        [Test()]
        public void FrontTest()
        {
            circularQueue.EnQueue(5);
            Assert.AreEqual(5, circularQueue.Front());
        }

        [Order(5)]
        [Test()]
        public void RearTest()
        {
            Assert.AreEqual(5, circularQueue.Rear());
        }

        [Order(6)]
        [Test()]
        public void IsEmptyTest()
        {
            Assert.AreEqual(false, this.circularQueue.IsEmpty());
        }

        [Order(7)]
        [Test()]
        public void IsFullTest()
        {
            Assert.AreEqual(false, this.circularQueue.IsFull());
        }
    }
}