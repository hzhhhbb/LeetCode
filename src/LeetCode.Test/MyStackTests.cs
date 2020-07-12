using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class MyStackTests
    {
        private MyStack obj = null;

        [Test()]
        [Order(1)]
        public void MyStackTest()
        {
            this.obj = new MyStack();

            Assert.True(this.obj != null);
        }

        [Order(2)]
        [Test()]
        public void PushTest()
        {
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
        }

        [Order(3)]
        [Test()]
        public void PopTest()
        {
            Assert.True(obj.Pop()==3);
        }

        [Order(4)]
        [Test()]
        public void TopTest()
        {
            Assert.True(obj.Top()==2);
        }

        [Order(5)]
        [Test()]
        public void EmptyTest()
        {
            Assert.True(obj.Empty()==false);
        }
    }
}