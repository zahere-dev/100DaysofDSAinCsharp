using _100DaysofDSAinCsharp.src.Day01;

namespace _100DaysofDSAinCsharp.src.Day08
{
    public class Odd_Even_Linked_List
    {

        /// <summary>
        /// Input linkedlist 1 -> 2 -> 3 -> 4 -> 5 -> 6
        /// </summary>
        /// <param name="head">1 -> 2 -> 3 -> 4 -> 5 -> 6</param>
        /// <returns>2 -> 4 -> 6 -> 1 -> 2 -> 3</returns>
        public static Node Run(Node head)
        {
            //handle edge cases
            if (head == null || head.next == null) return head;

            //Create Dummy Nodes Odd and Even
            Node dummyEven = new Node(-1);
            Node dummyOdd = new Node(-1);

            //Create tails of the dummy Nodes
            //We need these nodes to append nodes with even or value at the end
            Node eventTail = dummyEven;
            Node oddTail = dummyOdd;

            //declare a node to iterate over the head;
            var currentNode = head;

            //Loop until currentNode != null
            while (currentNode != null)
            {
                //if element not multiple of 2 then it's an odd number
                if (currentNode.element % 2 != 0)
                {
                    //Append the event to tails next
                    //for the first iteration -1 -> 1
                    //third iteration -1 -> 1 -> 3
                    // fifth iteration -1 -> 1 -> 3-> 5
                    oddTail.next = currentNode;
                    //Move the pointer to next
                    oddTail = oddTail.next;
                }
                else
                {
                    eventTail.next = currentNode;
                    eventTail = eventTail.next;
                }

                currentNode = currentNode.next;

            }

            /// attach eventail         dummOdd.next;
            /// -1 -> 2 -> 4 -> 6 - >  1 -> 2 -> 3
            eventTail.next = dummyOdd.next;

            return dummyEven.next;

        }
    }
}

