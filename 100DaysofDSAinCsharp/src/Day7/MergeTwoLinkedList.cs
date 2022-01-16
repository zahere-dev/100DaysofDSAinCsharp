using _100DaysofDSAinCsharp.src.Day1;

namespace _100DaysofDSAinCsharp.src.Day7
{
    public class MergeTwoLinkedList
    {

        public static Node Merge(Node head1, Node head2)
        {
            if (head1 == null || head2 == null) return head1 != null ? head1 : head2;

            Node dummy = new Node(-1);
            Node prev = dummy;
            var headOne = head1;
            var headTwo = head2;


            while (headOne != null && headTwo != null)
            {
                if (headOne.element < headTwo.element)
                {
                    prev.next = headOne;
                    headOne = headOne.next;

                }
                else
                {
                    prev.next = headTwo;
                    headTwo = headTwo.next;
                }

                prev = prev.next;

            }

            prev.next = headOne != null ? headOne : headTwo;



            return dummy.next;
        }
    }
}
