using _100DaysofDSAinCsharp.src.Day1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day9Tests
    {
        [TestMethod]
        public void ShiftOrRotateLinkedListTests()
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.addLast(1);
            sll.addLast(2);
            sll.addLast(3);
            sll.addLast(4);
            sll.addLast(5);
            sll.display();
            var res = _100DaysofDSAinCsharp.src.Day9.ShiftOrRotateLinkedList.RotateOrShift(sll.head, 2);
            sll.head = res;
            sll.display();

            Assert.AreEqual(4, sll.head.element);
            Assert.AreEqual(5, sll.head.next.element);





        }


    }
}
