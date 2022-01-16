using _100DaysofDSAinCsharp.src.Day1;
using System;

namespace _100DaysofDSAinCsharp.src.Day7
{
    public class Day7Ops
    {
        public static void Run()
        {
            SinglyLinkedList sl1 = new SinglyLinkedList();
            sl1.addLast(1);
            sl1.addLast(2);
            sl1.addLast(6);
            sl1.addLast(7);
            sl1.addLast(15);
            sl1.addLast(24);
            sl1.addLast(29);
            sl1.display();

            SinglyLinkedList sl2 = new SinglyLinkedList();
            sl2.addLast(-1);
            sl2.addLast(0);
            sl2.addLast(6);
            sl2.addLast(17);
            sl2.display();


            var res = MergeTwoLinkedList.Merge(sl1.head, sl2.head);
            while (res != null)
            {
                Console.Write($"{res.element}-->");
                res = res.next;

            }
            Console.WriteLine();







        }





    }
}
