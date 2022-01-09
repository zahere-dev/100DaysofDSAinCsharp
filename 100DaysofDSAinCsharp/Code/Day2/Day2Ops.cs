namespace _100DaysofDSAinCsharp.Code.Day2
{
    public class Day2Ops
    {
        public static void Run()
        {
            CircularLinkedList cll = new CircularLinkedList();

            cll.addFirst(3);
            cll.display();

            cll.addFirst(7);
            cll.display();

            cll.addLast(6);

            cll.display();


            cll.addAnywhere(2, 2);
            cll.display();

            cll.addAnywhere(9, 0);
            cll.display();

            cll.addFirst(7);
            cll.addFirst(7);


            cll.removeLast();
            cll.display();

            cll.removeFirst();
            cll.display();

            cll.removeAtGivenPosition(1);
            cll.display();

            cll.addFirst(7);
            cll.addFirst(7);
            cll.removeAtGivenPosition(5);
            cll.display();

            cll.removeDuplicates();
            cll.display();

            cll.reverse_approach1();
            cll.display();
        }

    }
}
