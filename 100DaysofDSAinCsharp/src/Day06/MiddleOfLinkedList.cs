using _100DaysofDSAinCsharp.src.Day01;

namespace _100DaysofDSAinCsharp.src.Day06
{
    public class MiddleOfLinkedList
    {
        public static SinglyLinkedList TwoPointerMethod(SinglyLinkedList sl1)
        {
            var slow = sl1.head;
            var fast = sl1.head;

            int fastCounter = 0;
            int slowCounter = 0;
            while (fast != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                fastCounter = fastCounter + 2;
                slowCounter++;
            }
            sl1.head = slow;
            return sl1;
        }
    }
}
