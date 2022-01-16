using _100DaysofDSAinCsharp.src.Day1;
using _100DaysofDSAinCsharp.src.Day6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day6Tests
    {
        [TestMethod]
        public void MergeLinkedListTests()
        {



            SinglyLinkedList sl2 = new SinglyLinkedList();
            sl2.addLast(1);
            sl2.addLast(0);
            sl2.addLast(6);
            sl2.addLast(0);
            sl2.addLast(17);
            sl2.display();
            Assert.AreEqual(6, RemoveGivenElements.RemoveElements(sl2.head, 0).next.element);




        }
    }
}
