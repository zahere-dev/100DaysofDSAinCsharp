using _100DaysofDSAinCsharp.src.Day1;
using _100DaysofDSAinCsharp.src.Day8;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day8Tests
    {
        [TestMethod]
        public void OddEvenTests()
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.addLast(1);
            sll.addLast(2);
            sll.addLast(3);
            sll.addLast(4);
            sll.addLast(5);
            sll.display();
            var res = Odd_Even_Linked_List.Run(sll.head);
            sll.head = res;
            System.Console.WriteLine("Print");
            sll.display();






        }
    }
}
