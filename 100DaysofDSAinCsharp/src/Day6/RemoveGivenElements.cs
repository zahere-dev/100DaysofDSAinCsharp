using _100DaysofDSAinCsharp.src.Day1;

namespace _100DaysofDSAinCsharp.src.Day6
{
    public class RemoveGivenElements
    {
        public static Node RemoveElements(Node head, int val)
        {
            var currentNode = head;
            var tempHead = head;
            int counter = 0;
            while (currentNode != null)
            {
                if (currentNode.element == val)
                {
                    tempHead = removeAtGivenPosition(counter, tempHead);
                    counter--;
                }

                currentNode = currentNode.next;
                counter++;
            }

            return tempHead;


        }

        public static Node removeAtGivenPosition(int position, Node head)
        {
            int size = length(head);
            if (size == 0 || position < 0 || position > size)
            {
                return head;
            }
            else if (position == 0)
            {
                head = head.next;
            }
            else
            {
                var currentNode = head;
                int counter = 0;
                while (currentNode != null)
                {
                    if (counter == position - 1)
                    {
                        //currentNode.next = currentNode.next.next == null ? null : currentNode.next.next;
                        var nextNode = currentNode.next;
                        currentNode = nextNode.next == null ? null : nextNode.next;
                        break;
                    }
                    currentNode = currentNode.next;
                    counter++;
                }
            }

            return head;
        }

        public static int length(Node head)
        {
            var currentNode = head;
            int counter = 0;
            while (currentNode != null)
            {
                currentNode = currentNode.next;
                counter++;
            }
            return counter;
        }
    }
}
