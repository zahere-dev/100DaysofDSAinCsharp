using _100DaysofDSAinCsharp.src.Day1;

namespace _100DaysofDSAinCsharp.src.Day9
{
    public class ShiftOrRotateLinkedList
    {


        /// <summary>
        /// Input linkedlist 1 -> 2 -> 3 -> 4 -> 5
        /// nodes to be shifted k = 2               
        /// </summary>
        /// <param name="head">1 -> 2 -> 3 -> 4 -> 5</param>
        /// <param name="k">Nodes to be shifted - 2</param>
        /// <returns> 4 -> 5 -> 1 -> 2 -> 3</returns>
        public static Node RotateOrShift(Node head, int k)
        {
            //Handle edge cases
            if (head == null || head.next == null || k == 0) return head;

            var currentNode = head;

            //Get the length of the linkedlist
            int length = 1;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
                length++;
            }

            //Set the last nodes next as head so that it becomes a circular linkedlist
            currentNode.next = head;

            //identify the node that needs to be broken by subtracting k from the length i.e.
            //if k =2, then length - k = 3 - we need to break the link after the 3rd node.
            k = length - k;

            //Reach the kth node 
            while (k-- > 0) currentNode = currentNode.next;

            //make the next node as head and break the connection
            head = currentNode.next;
            currentNode.next = null;


            return head;
        }
    }
}
