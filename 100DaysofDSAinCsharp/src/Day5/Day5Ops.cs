using _100DaysofDSAinCsharp.src.Day1;

namespace _100DaysofDSAinCsharp.src.Day5
{
    public class Day5Ops
    {
        public static void Run()
        {
            SinglyLinkedList sl1 = new SinglyLinkedList();
            //sl1.addFirst(1);
            //sl1.addFirst(7);
            //sl1.addFirst(8);
            //sl1.addFirst(9);
            //System.Console.WriteLine(sl1.size);
            //sl1.display();

            //SinglyLinkedList sl2 = new SinglyLinkedList();
            //sl2.addFirst(9);
            //sl2.addFirst(8);
            //sl2.addFirst(7);
            //sl2.display();

            ////SumOfLinkedList.AddTwoListRecursively(sl1, sl2).display();


            //SumOfLinkedList.Add2ListsIterative(sl1, sl2).display();


            SinglyLinkedList sl3 = new SinglyLinkedList();
            sl3.addLast(0);
            sl3.addLast(1);
            sl3.addLast(2);
            sl3.addLast(3);
            sl3.addLast(4);
            sl3.addLast(5);
            sl3.addLast(6);
            sl3.addLast(7);
            sl3.addLast(8);
            sl3.addLast(9);
            sl3.display();
            System.Console.WriteLine(sl3.size);
            int pos = sl3.size - 10;
            System.Console.WriteLine(pos);
            sl3.removeAtGivenPosition(pos);
            sl3.display();







        }
    }
}
