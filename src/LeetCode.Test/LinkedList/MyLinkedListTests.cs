using LeetCode.LinkedList;

using NUnit.Framework;

namespace LeetCode.Tests.LinkedList
{
    [TestFixture()]
    public class MyLinkedListTests
    {
        [Test()]
        public void MyLinkedListTest()
        {
            MyLinkedList linkedList = new MyLinkedList();
            linkedList.AddAtHead(1);
            linkedList.AddAtTail(3);
            linkedList.AddAtIndex(1, 2);

            var expected = 2;
            Assert.AreEqual(expected, linkedList.Get(1));

            linkedList.DeleteAtIndex(1);

            expected = 3;
            Assert.AreEqual(expected, linkedList.Get(1));
        }

        [Test()]
        public void MyLinkedListTest1()
        {
            MyLinkedList linkedList = new MyLinkedList();
            linkedList.AddAtHead(7);
            linkedList.AddAtHead(2);
            linkedList.AddAtHead(1);
            linkedList.AddAtIndex(3, 0);
            linkedList.DeleteAtIndex(2);
            linkedList.AddAtHead(6);
            linkedList.AddAtTail(4);

            var expected = 4;
            Assert.AreEqual(expected, linkedList.Get(4));

            linkedList.AddAtHead(4);
            linkedList.AddAtIndex(5, 0);
            linkedList.AddAtHead(6);
        }

        [Test()]
        public void MyLinkedList2Test()
        {
            MyLinkedList2 linkedList = new MyLinkedList2();
            linkedList.AddAtHead(1);
            linkedList.AddAtTail(3);
            linkedList.AddAtIndex(1, 2);

            var expected = 2;
            Assert.AreEqual(expected, linkedList.Get(1));

            linkedList.DeleteAtIndex(1);

            expected = 3;
            Assert.AreEqual(expected, linkedList.Get(1));
        }

        [Test()]
        public void MyLinkedList2Test1()
        {
            MyLinkedList2 linkedList = new MyLinkedList2();
            linkedList.AddAtHead(7);
            linkedList.AddAtHead(2);
            linkedList.AddAtHead(1);
            linkedList.AddAtIndex(3, 0);
            linkedList.DeleteAtIndex(2);
            linkedList.AddAtHead(6);
            linkedList.AddAtTail(4);

            var expected = 4;
            Assert.AreEqual(expected, linkedList.Get(4));

            linkedList.AddAtHead(4);
            linkedList.AddAtIndex(5, 0);
            linkedList.AddAtHead(6);
        }
    }
}