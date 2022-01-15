using _100DaysofDSAinCsharp.src.Day1;
using System;

namespace _100DaysofDSAinCsharp.src.Day6
{
    public class Day6Ops
    {
        public static void Run()
        {
            //SinglyLinkedList sl3 = new SinglyLinkedList();
            //sl3.addLast(0);
            //sl3.addLast(1);
            //sl3.addLast(2);
            //sl3.addLast(3);
            //sl3.addLast(4);
            //sl3.addLast(5);
            //sl3.addLast(3);
            //sl3.addLast(2);
            //sl3.addLast(1);
            //sl3.addLast(0);
            //sl3.display();
            //System.Console.WriteLine(LinkedListPalindrome.TwoPointerMethod(sl3));
            //sl3.display();


            SinglyLinkedList sll = new SinglyLinkedList();
            //sll.addLast(1);
            //sll.addLast(0);
            //sll.addLast(0);
            //System.Console.WriteLine(LinkedListPalindrome.IsPalindromeLeetCode(sll.head));
            //sll.display();

            sll.addLast(7);
            sll.addLast(7);
            sll.addLast(6);
            sll.addLast(7);
            sll.addLast(7);
            sll.display();

            var currentNode = RemoveGivenElements.RemoveElements(sll.head, 7);
            while (currentNode != null)
            {
                Console.Write($"{currentNode.element}-->");
                currentNode = currentNode.next;

            }
            Console.WriteLine();
            //sll.display();


        }
    }
}
