using LeetCode.LinkedList;
using NUnit.Framework;

namespace LeetCode.Tests.LinkedList
{
    [TestFixture()]
    public class FlattenAMultilevelDoublyLinkedListTests
    {
        [Test()]
        public void FlattenTest()
        {
            Node levelOne=new Node();
            Node levelOne1=new Node();
            Node levelOne2=new Node();
            levelOne.val = 0;
            levelOne1.val = 1;
            levelOne2.val = 2;
            levelOne.next = levelOne1;
            levelOne1.prev = levelOne;
            levelOne1.next = levelOne2;
            levelOne2.prev = levelOne1;

            Node levelTwoHead=new Node();
            Node levelTwo1=new Node();
            Node levelTwo2=new Node();
            Node levelTwo3=new Node();
            levelTwoHead.val = 3;
            levelTwo1.val = 4;
            levelTwo2.val = 5;
            levelTwo3.val = 6;
            levelTwoHead.next = levelTwo1;
            levelTwo1.prev = levelTwoHead;
            levelTwo1.next = levelTwo2;
            levelTwo2.prev = levelTwo1;
            levelTwo2.next = levelTwo3;
            levelTwo3.prev = levelTwo2;

            Node levelThreeHead=new Node();
            Node levelThree1=new Node();
            Node levelThree2=new Node();
            levelThreeHead.val = 7;
            levelThree1.val = 8;
            levelThree2.val = 9;
            levelThreeHead.next = levelThree1;
            levelThree1.prev = levelThreeHead;
            levelThree1.next = levelThree2;
            levelThree2.prev = levelThree1;

            levelOne1.child = levelTwoHead;
            levelTwo2.child = levelThreeHead;

            Node expected=new Node(0);
            Node expected1=new Node(1);
            Node expected2=new Node(3);
            Node expected3=new Node(4);
            Node expected4=new Node(5);
            Node expected5=new Node(7);
            Node expected6=new Node(8);
            Node expected7=new Node(9);
            Node expected8=new Node(6);
            Node expected9=new Node(2);

            expected.next = expected1;
            expected1.prev = expected;

            expected1.next = expected2;
            expected2.prev = expected1;

            expected2.next = expected3;
            expected3.prev = expected2;

            expected3.next = expected4;
            expected4.prev = expected3;

            expected4.next = expected5;
            expected5.prev = expected4;

            expected5.next = expected6;
            expected6.prev = expected5;

            expected6.next = expected7;
            expected7.prev = expected6;

            expected7.next = expected8;
            expected8.prev = expected7;

            expected8.next = expected9;
            expected9.prev = expected8;

            Assert.IsTrue(expected.IsEqual(new FlattenAMultilevelDoublyLinkedList().Flatten(levelOne)));
        }

          [Test()]
        public void FlattenTest1()
        {
            Node levelOne=new Node();
            Node levelOne1=new Node();
            Node levelOne2=new Node();
            levelOne.val = 0;
            levelOne1.val = 1;
            levelOne2.val = 2;
            levelOne.next = levelOne1;
            levelOne1.prev = levelOne;
            levelOne1.next = levelOne2;
            levelOne2.prev = levelOne1;

            Node levelTwoHead=new Node();
            Node levelTwo1=new Node();
            Node levelTwo2=new Node();
            levelTwoHead.val = 3;
            levelTwo1.val = 4;
            levelTwo2.val = 5;
            levelTwoHead.next = levelTwo1;
            levelTwo1.prev = levelTwoHead;
            levelTwo1.next = levelTwo2;
            levelTwo2.prev = levelTwo1;

            levelOne1.child = levelTwoHead;
            levelTwoHead.prev = levelOne1;

            Node expected=new Node(0);
            Node expected1=new Node(1);
            Node expected2=new Node(3);
            Node expected3=new Node(4);
            Node expected4=new Node(5);
            Node expected5=new Node(2);

            expected.next = expected1;
            expected1.prev = expected;

            expected1.next = expected2;
            expected2.prev = expected1;

            expected2.next = expected3;
            expected3.prev = expected2;

            expected3.next = expected4;
            expected4.prev = expected3;

            expected4.next = expected5;
            expected5.prev = expected4;

            Assert.IsTrue(expected.IsEqual(new FlattenAMultilevelDoublyLinkedList().Flatten(levelOne)));
        }

        [Test()]
        public void FlattenTest2()
        {
            Node levelOne=new Node();
            Node levelOne1=new Node();
            levelOne.val = 1;
            levelOne1.val = 2;
            levelOne.next = levelOne1;
            levelOne1.prev = levelOne;

            Node levelTwoHead=new Node(3);
         
            levelOne.child = levelTwoHead;
            levelTwoHead.prev = levelOne;

            Node expected=new Node(1);
            Node expected1=new Node(3);
            Node expected2=new Node(2);
           

            expected.next = expected1;
            expected1.prev = expected;

            expected1.next = expected2;
            expected2.prev = expected1;


            Assert.IsTrue(expected.IsEqual(new FlattenAMultilevelDoublyLinkedList().Flatten(levelOne)));
        }
    }
}