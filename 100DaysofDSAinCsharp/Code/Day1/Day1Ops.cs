namespace _100DaysofDSAinCsharp.Code.Day1
{
    public class Day1Ops
    {
        public static void Run()
        {
            SinglyLinkedList sll = new SinglyLinkedList();

            //Testing edge cases
            sll.removeLast();
            sll.display();

            //Testing edge cases
            sll.removeFirst();
            sll.display();


            sll.addLast(7);
            sll.removeFirst();
            sll.display();

            sll.addLast(5);

            sll.addLast(6);
            sll.addLast(2);
            sll.addLast(5);
            sll.addLast(5);
            sll.addLast(6);
            sll.addLast(9);
            sll.addLast(6);
            sll.addLast(6);
            sll.addLast(3);
            sll.addLast(6);
            sll.addLast(6);
            sll.addLast(6);
            sll.addLast(5);
            sll.addLast(6);
            sll.addLast(6);
            sll.addLast(6);
            sll.addLast(6);
            sll.addLast(6);
            sll.display();


            sll.addLast(3);
            sll.addFirst(1);
            sll.display();


            sll.addAnywhere(22, 4);
            sll.display();

            sll.removeLast();
            sll.display();

            sll.removeFirst();
            sll.display();


            sll.removeAtGivenPosition(3);
            sll.display();

            sll.removeAtGivenPosition(0);
            sll.display();

            sll.removeDuplicates();
            sll.display();

            System.Console.WriteLine(sll.length());
            sll.reverse_approach1();
            sll.display();

            //sll.removeAtGivenPosition(11);
            //sll.display();

        }



    }
}
