using _100DaysofDSAinCsharp.src.Day01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day01Tests
    {
        [TestMethod]
        public void TestaddNodes()
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.addFirst(1);

            Assert.AreEqual(1, sll.length());

            sll.addLast(1);
            Assert.AreEqual(2, sll.length());

            sll.addAnywhere(4, 1);
            Assert.AreEqual(3, sll.length());

            sll.addAnywhere(4, 4);
            Assert.AreNotEqual(3, sll.length());
        }

        [TestMethod]
        public void TestremoveNodes()
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.removeFirst();

            Assert.AreEqual(0, sll.length());

            sll.removeLast();
            Assert.AreEqual(0, sll.length());

            sll.addFirst(3);
            sll.addFirst(4);
            sll.addFirst(6);
            sll.removeFirst();
            Assert.AreEqual(2, sll.length());

            sll.removeAtGivenPosition(0);
            Assert.AreEqual(1, sll.length());


            sll.addFirst(3);
            sll.addFirst(2);
            sll.addFirst(6);
            sll.addFirst(2);
            sll.removeDuplicates();
            Assert.AreEqual(3, sll.length());
            Assert.AreEqual(6, sll.findElementbyPosition(1));



        }

        [TestMethod]
        public void TestReverse()
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.addLast(3);
            sll.addLast(4);
            sll.addLast(6);

            sll.display();
            sll.reverse_approach1();
            sll.display();

            Assert.AreEqual(6, sll.findElementbyPosition(0));

        }
    }
}
