namespace _100DaysofDSAinCsharp.src.Day2
{
    public class Day2Ops
    {
        public static void Run()
        {
            #region CircularLinkedList
            CircularLinkedList cll = new CircularLinkedList();

            //cll.addFirst(3);
            //cll.display();

            //cll.addFirst(7);
            //cll.display();

            //cll.addLast(6);

            //cll.display();


            //cll.addAnywhere(2, 2);
            //cll.display();

            //cll.addAnywhere(9, 0);
            //cll.display();

            //cll.addFirst(7);
            //cll.addFirst(7);


            //cll.removeLast();
            //cll.display();

            //cll.removeFirst();
            //cll.display();

            //cll.removeAtGivenPosition(1);
            //cll.display();

            //cll.addFirst(7);
            //cll.addFirst(7);
            //cll.removeAtGivenPosition(5);
            //cll.display();

            //cll.removeDuplicates();
            //cll.display();

            //cll.reverse_approach1();
            //cll.display();
            #endregion

            #region DoublyLinkedList
            DoublyLinkedList dll = new DoublyLinkedList();
            dll.addLast(75);
            dll.display();

            dll.addFirst(3);
            dll.addFirst(38);
            dll.addFirst(85);
            dll.addFirst(38);
            dll.addFirst(12);
            dll.addLast(75);
            dll.addFirst(45);
            dll.display();

            dll.addLast(75);
            dll.addLast(79);
            dll.display();

            dll.addAnywhere(99, 1);
            dll.addAnywhere(98, 0);
            dll.addAnywhere(97, 13);
            dll.display();

            dll.removeFirst();
            dll.display();

            dll.removeLast();
            dll.display();


            dll.removeAtGivenPosition(1);
            dll.display();

            dll.removeAtGivenPosition(0);
            dll.display();

            dll.removeAtGivenPosition(6);
            dll.display();

            dll.removeDuplicates();
            dll.display();

            dll.reverse_approach1();
            dll.display();
            #endregion


        }

    }
}

