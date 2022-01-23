using _100DaysofDSAinCsharp.src.Day12;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day12Tests
    {
        [TestMethod]
        public void AddFirstTest()
        {

            LinkedList ll = new LinkedList();
            Assert.AreEqual(0, ll.size);
            ll.addFirst(1);
            ll.display();

            Assert.AreEqual(1, ll.head.value);
            Assert.AreEqual(1, ll.tail.value);

            ll.addFirst(2);
            ll.display();
            Assert.AreEqual(2, ll.head.value);
            Assert.AreEqual(1, ll.tail.value);
            Assert.AreEqual(2, ll.size);
        }

        [TestMethod]
        public void AddAnywhereTest()
        {

            LinkedList ll = new LinkedList();
            Assert.AreEqual(0, ll.size);
            ll.addFirst(1);
            ll.addFirst(2);
            ll.addFirst(3);
            ll.addFirst(4);
            ll.display();
            System.Console.WriteLine(ll.length());
            ll.addAnywhere(6, 1);
            Assert.AreEqual(6, ll.head.value);
            ll.display();
            System.Console.WriteLine(ll.length());

            ll.addAnywhere(7, 3);
            ll.display();
            System.Console.WriteLine(ll.length());
            Assert.AreEqual(7, ll.head.next.next.value);

            ll.addAnywhere(8, 6);
            ll.display();
            System.Console.WriteLine(ll.length());
            Assert.AreEqual(8, ll.tail.value);

        }


        [TestMethod]
        public void AddLastTest()
        {

            LinkedList ll = new LinkedList();
            Assert.AreEqual(0, ll.size);
            ll.addLast(1);
            ll.display();

            Assert.AreEqual(1, ll.head.value);
            Assert.AreEqual(1, ll.tail.value);

            ll.addLast(2);
            ll.display();
            Assert.AreEqual(1, ll.head.value);
            Assert.AreEqual(2, ll.tail.value);
            Assert.AreEqual(2, ll.size);
        }

        [TestMethod]
        public void RemoveFirsTest()
        {

            LinkedList ll = new LinkedList();
            Assert.AreEqual(0, ll.size);
            ll.addLast(1);
            ll.addLast(2);
            ll.display();
            ll.removeFirst();

            Assert.AreEqual(2, ll.head.value);
            Assert.AreEqual(2, ll.tail.value);

        }

        [TestMethod]
        public void RemoveAnywhereTest()
        {
            LinkedList ll = new LinkedList();
            Assert.AreEqual(0, ll.size);
            ll.addFirst(1);
            ll.addFirst(2);
            ll.addFirst(3);
            ll.addFirst(4);
            ll.display();
            System.Console.WriteLine(ll.length());
            ll.removeAnywhere(1);
            Assert.AreEqual(3, ll.head.value);
            ll.display();
            System.Console.WriteLine(ll.length());

            ll.addFirst(5);
            ll.addFirst(6);
            ll.removeAnywhere(3);
            ll.display();
            System.Console.WriteLine(ll.length());
            Assert.AreEqual(2, ll.head.next.next.value);

            ll.removeAnywhere(4);
            ll.display();
            System.Console.WriteLine(ll.length());
            Assert.AreEqual(2, ll.tail.value);

        }

        [TestMethod]
        public void RemoveLastTest()
        {

            LinkedList ll = new LinkedList();
            Assert.AreEqual(0, ll.size);
            ll.addLast(1);
            ll.addLast(2);
            ll.display();
            ll.removeLast();
            ll.display();

            Assert.AreEqual(1, ll.head.value);
            Assert.AreEqual(1, ll.tail.value);

        }

        [TestMethod]
        public void ReverseTest()
        {

            LinkedList ll = new LinkedList();
            ll.addFirst(1);
            ll.addFirst(2);
            ll.addFirst(3);
            ll.addFirst(4);
            ll.display();

            ll.reverse();
            ll.display();

            Assert.AreEqual(1, ll.head.value);

            ll.reverseRecursively();
            ll.display();
            Assert.AreEqual(3, ll.head.next.value);


        }

        [TestMethod]
        public void ReverseKGroup()
        {
            LinkedList sll = new LinkedList();
            sll.addLast(1);
            sll.addLast(2);
            sll.addLast(3);
            sll.addLast(4);
            sll.addLast(5);
            sll.addLast(6);
            sll.addLast(7);
            sll.display();
            sll.reverseKGroupByCreatingNewList(3);
            sll.display();
        }


        [TestMethod]
        public void Add2ListTest()
        {
            LinkedList sl1 = new LinkedList();
            sl1.addFirst(1);
            sl1.addFirst(7);
            sl1.addFirst(8);
            sl1.addFirst(9);
            System.Console.WriteLine(sl1.size);
            sl1.display();

            LinkedList sl2 = new LinkedList();
            sl2.addFirst(9);
            sl2.addFirst(8);
            sl2.addFirst(7);
            sl2.display();

            ////SumOfLinkedList.AddTwoListRecursively(sl1, sl2).display();


            var res = LinkedList.Add2ListsIterative(sl1, sl2);
            res.display();

            Assert.AreEqual(2, res.head.value);

        }

        [TestMethod]
        public void MiddleOfLinkedListSlowAndFastPointerMethod()
        {
            LinkedList sl1 = new LinkedList();
            sl1.addFirst(1);
            sl1.addFirst(7);
            sl1.addFirst(8);
            sl1.addFirst(9);
            sl1.addFirst(11);
            sl1.addFirst(15);
            System.Console.WriteLine(sl1.size);
            sl1.display();

            ////SumOfLinkedList.AddTwoListRecursively(sl1, sl2).display();


            var res = LinkedList.MiddleOfLinkedListSlowAndFastPointerMethod(sl1);
            res.display();

            Assert.AreEqual(8, res.head.value);

        }

    }
}

