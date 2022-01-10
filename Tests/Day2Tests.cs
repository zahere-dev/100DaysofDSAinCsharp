using _100DaysofDSAinCsharp.src.Day2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day2Tests
    {
        [TestMethod]
        public void TestaddNodes()
        {
            CircularLinkedList cll = new CircularLinkedList();
            cll.addFirst(1);

            Assert.AreEqual(1, cll.length());

            cll.addLast(1);
            Assert.AreEqual(2, cll.length());

            cll.addAnywhere(4, 1);
            Assert.AreEqual(3, cll.length());

            cll.display();
            cll.addAnywhere(4, 4);
            Assert.AreNotEqual(4, cll.length());


            DoublyLinkedList dll = new DoublyLinkedList();

            dll.addFirst(1);
            Assert.AreEqual(1, dll.length());

            dll.addLast(1);
            Assert.AreEqual(2, dll.length());

            dll.addAnywhere(4, 1);
            Assert.AreEqual(3, dll.length());

            dll.display();
            dll.addAnywhere(4, 4);
            Assert.AreNotEqual(4, dll.length());
        }

        [TestMethod]
        public void TestremoveNodes()
        {
            CircularLinkedList cll = new CircularLinkedList();
            cll.removeFirst();

            Assert.AreEqual(0, cll.length());

            cll.removeLast();
            Assert.AreEqual(0, cll.length());

            cll.addFirst(3);
            cll.addFirst(4);
            cll.addFirst(6);
            cll.removeFirst();
            Assert.AreEqual(2, cll.length());

            cll.removeAtGivenPosition(0);
            Assert.AreEqual(1, cll.length());


            cll.addFirst(3);
            cll.addFirst(2);
            cll.addFirst(6);
            cll.addFirst(2);
            cll.removeDuplicates();
            Assert.AreEqual(3, cll.length());




        }

        [TestMethod]
        public void TestReverse()
        {
            CircularLinkedList cll = new CircularLinkedList();
            cll.addLast(3);
            cll.addLast(4);
            cll.addLast(6);

            cll.display();
            cll.reverse_approach1();
            cll.display();



        }
    }
}
