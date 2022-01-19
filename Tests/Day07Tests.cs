using _100DaysofDSAinCsharp.src.Day01;
using _100DaysofDSAinCsharp.src.Day07;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day07Tests
    {
        [TestMethod]
        public void MergeLinkedListTests()
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.addLast(1);
            sll.addLast(2);
            sll.addLast(3);
            sll.display();

            sll.display();


            SinglyLinkedList sl2 = new SinglyLinkedList();
            sl2.addLast(-1);
            sl2.addLast(0);
            sl2.addLast(6);
            sl2.addLast(17);
            sl2.display();
            Assert.AreEqual(1, MergeTwoLinkedList.Merge(sll.head, sl2.head).next.next.element);
            Assert.AreNotEqual(1, MergeTwoLinkedList.Merge(sll.head, sl2.head).next.element);



        }
    }
}
