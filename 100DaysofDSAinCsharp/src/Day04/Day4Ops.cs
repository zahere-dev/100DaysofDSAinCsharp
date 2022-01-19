using _100DaysofDSAinCsharp.src.Day02;

namespace _100DaysofDSAinCsharp.src.Day04
{
    public class Day4Ops
    {
        public static void Run()
        {
            //SinglyLinkedList sll = new SinglyLinkedList();
            //sll.addLast(1);
            //sll.addLast(2);
            //sll.addLast(3);
            //sll.addLast(4);
            //sll.addLast(5);
            //sll.addLast(6);
            //sll.addLast(7);
            //sll.display();
            //sll.reverseKGroupByCreatingNewList(3);
            //sll.display();
            ////sll.reverseKGroupOnTheSameList(3);
            ////sll.display();
            //sll.reverseKGroupRecursively(3, sll.length(), null, null, null, null);
            //sll.display();


            //CircularLinkedList cll = new CircularLinkedList();
            //cll.addLast(1);
            //cll.addLast(2);
            //cll.addLast(3);
            //cll.addLast(4);
            //cll.addLast(5);
            //cll.addLast(6);
            //cll.addLast(7);
            //cll.display();
            ////cll.reverseKGroupByCreatingNewList(3);
            //cll.display();
            //System.Console.WriteLine(cll.length());
            //cll.reverseKGroupOnTheSameList(3);
            //cll.display();
            //cll.reverseKGroupRecursively(3, cll.length(), null, null, null, null);
            //cll.display();


            DoublyLinkedList dll = new DoublyLinkedList();
            dll.addLast(1);
            dll.addLast(2);
            dll.addLast(3);
            dll.addLast(4);
            dll.addLast(5);
            dll.addLast(6);
            dll.addLast(7);
            dll.display();
            //cll.reverseKGroupByCreatingNewList(3);
            //dll.display();
            //System.Console.WriteLine(cll.length());
            dll.reverseKGroupOnTheSameList(3);
            dll.display();
            dll.reverseKGroupRecursively(3, dll.length(), null, null, null, null);
            dll.display();

        }
    }
}
