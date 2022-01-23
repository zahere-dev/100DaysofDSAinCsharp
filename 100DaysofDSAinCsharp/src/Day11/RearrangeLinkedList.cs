using _100DaysofDSAinCsharp.src.Day01;

namespace _100DaysofDSAinCsharp.src.Day11
{
    public class RearrangeLinkedList
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="head">1 -> 3 -> 0 -> 5 -> 2 -> 1 -> 4 </param>
        /// <param name="k">3</param>
        /// <returns>1 -> 0 -> 2 -> 3 ->5 -> 4</returns>
        public static Node Rearrange(Node head, int k)
        {

            var currentNode = head;
            Node dummyNode = new Node(-1);
            var lessThanKNodes = new Node(-1);
            var kNodes = new Node(-1);
            var greaterThanKNodes = new Node(-1);


            while (currentNode != null)
            {
                if (currentNode.element < k)
                {
                    addFirst(lessThanKNodes, currentNode);
                }
                else if (currentNode.element > k)
                {
                    addFirst(greaterThanKNodes, currentNode);

                }
                else
                {

                    addFirst(kNodes, currentNode);

                }

                currentNode = currentNode.next;
            }


            kNodes = joinTwoNodes(kNodes.next, greaterThanKNodes.next);
            lessThanKNodes = joinTwoNodes(lessThanKNodes.next, kNodes);
            return lessThanKNodes;



        }

        private static Node addFirst(Node node, Node current)
        {
            //while (node.next != null)
            //{
            //    node = node.next;
            //}
            //node.next = new Node(element);

            current.next = node.next;
            node.next = current;

            return node;

        }

        private static Node joinTwoNodes(Node nod1, Node nod2)
        {
            var tempNode = nod1;
            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
            }

            tempNode.next = nod2;

            return tempNode;
        }


    }
}
