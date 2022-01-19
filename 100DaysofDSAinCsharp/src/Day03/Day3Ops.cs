using _100DaysofDSAinCsharp.src.Day01;
using _100DaysofDSAinCsharp.src.Day02;

namespace _100DaysofDSAinCsharp.src.Day03
{
    public class Day3Ops
    {
        public static void Run()
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.addLast(1);
            sll.addLast(2);
            sll.addLast(3);
            sll.display();
            sll.reverseLinkedListRecursively();
            sll.display();


            CircularLinkedList cll = new CircularLinkedList();
            cll.addLast(4);
            cll.addLast(5);
            cll.addLast(6);
            cll.display();
            cll.reverseLinkedListRecursively();
            cll.display();


            DoublyLinkedList dll = new DoublyLinkedList();
            dll.addLast(7);
            dll.addLast(8);
            dll.addLast(9);
            dll.display();
            dll.reverseLinkedListRecursively();
            dll.display();

        }
    }
}
