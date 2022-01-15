using _100DaysofDSAinCsharp.src.Day1;

namespace _100DaysofDSAinCsharp.src.Day6
{
    public class LinkedListPalindrome
    {
        public static bool TwoPointerMethod(SinglyLinkedList sll)
        {
            SinglyLinkedList tempList = new SinglyLinkedList();

            var slow = sll.head;
            var fast = sll.head;

            int fastCounter = 0;
            int slowCounter = 0;
            while (fast != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                fastCounter = fastCounter + 2;
                slowCounter++;
            }

            var newHead = reverse(slow);
            var currentHead = sll.head;

            return isPalindrome(newHead, currentHead);
        }


        public static Node reverse(Node head)
        {
            Node currentNode = head;
            Node prevNode = null;

            while (currentNode != null)
            {
                var nextNode = currentNode.next;
                currentNode.next = prevNode;
                prevNode = currentNode;
                currentNode = nextNode;
            }

            return prevNode;
        }

        public static bool isPalindrome(Node newHead, Node currentHead)
        {
            bool res = true; ;
            while (newHead != null && currentHead != null)
            {
                if (newHead.element != currentHead.element)
                {
                    return false;
                }

                newHead = newHead.next;
                currentHead = currentHead.next;
            }
            return res;
        }




        public static bool IsPalindromeLeetCode(Node head)
        {

            var slowPointer = head;
            var fastPointer = head;

            while (fastPointer != null)
            {

                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next == null ? null : fastPointer.next.next;
            }

            var newHead = reverse(slowPointer);
            var currentNode = head;

            while (newHead != null)
            {

                if (newHead.element != currentNode.element)
                {
                    return false;
                }

                currentNode = currentNode.next;
                newHead = newHead.next;
            }

            return true;


        }



    }
}
