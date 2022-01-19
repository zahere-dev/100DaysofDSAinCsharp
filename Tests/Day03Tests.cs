using _100DaysofDSAinCsharp.src.Day01;
using _100DaysofDSAinCsharp.src.Day02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day03Tests
    {
        [TestMethod]
        public void TestaddNodes()
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.addLast(1);
            sll.addLast(2);
            sll.addLast(3);
            sll.display();
            sll.reverseLinkedListRecursively();
            sll.display();
            Assert.AreEqual(3, sll.findElementbyPosition(0));


            CircularLinkedList cll = new CircularLinkedList();
            cll.addLast(4);
            cll.addLast(5);
            cll.addLast(6);
            cll.display();
            cll.reverseLinkedListRecursively();
            cll.display();
            Assert.AreEqual(6, cll.findElementbyPosition(0));

            DoublyLinkedList dll = new DoublyLinkedList();
            dll.addLast(7);
            dll.addLast(8);
            dll.addLast(9);
            dll.display();
            dll.reverseLinkedListRecursively();
            dll.display();
            Assert.AreEqual(9, dll.findElementbyPosition(0));
        }


    }
}
