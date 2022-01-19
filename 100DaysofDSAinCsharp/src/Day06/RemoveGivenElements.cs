using _100DaysofDSAinCsharp.src.Day01;

namespace _100DaysofDSAinCsharp.src.Day06
{
    public class RemoveGivenElements
    {
        public static Node RemoveElements(Node head, int val)
        {
            Node helper = new Node(0)
            {
                next = head
            };
            Node p = helper;

            while (p.next != null)
            {
                if (p.next.element == val)
                {
                    Node next = p.next;
                    p.next = next.next;
                }
                else
                {
                    p = p.next;
                }
            }

            return helper.next;


        }
    }
}
