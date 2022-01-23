using _100DaysofDSAinCsharp.src.Day01;
using _100DaysofDSAinCsharp.src.Day11;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day11Tests
    {
        [TestMethod]
        public void RearrangeListTests()
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.addLast(1);
            sll.addLast(3);
            sll.addLast(0);
            sll.addLast(5);
            sll.addLast(2);
            sll.addLast(1);
            sll.addLast(4);
            sll.display();

            var res = RearrangeLinkedList.Rearrange(sll.head, 3);

            sll.head = res;
            sll.display();




        }
    }
}
