using System.Collections.Generic;

namespace _100DaysofDSAinCsharp.src.Day02
{
    public class NodeDL
    {
        public int element;
        public NodeDL next;
        public NodeDL previous;
        public NodeDL(int e)
        {
            element = e;
            next = null;
            previous = null;

        }
    }


    public class DoublyLinkedList
    {
        private NodeDL head;
        private NodeDL tail;
        private int size;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void addFirst(int e)
        {
            NodeDL newNode = new NodeDL(e);
            if (isEmpty())
            {
                head = newNode;
                tail = newNode;
                tail.previous = newNode;
            }
            else
            {
                newNode.next = head;
                head.previous = newNode;
                head = newNode;
            }
            size++;
        }

        public void addLast(int e)
        {
            NodeDL newNode = new NodeDL(e);
            if (isEmpty())
            {
                addFirst(e);
            }
            else
            {
                newNode.previous = tail;
                tail.next = newNode;
                tail = newNode;
                size++;
            }

        }


        public void addAnywhere(int e, int position)
        {
            if (position == 0)
            {
                addFirst(e);
            }
            else if (position > length() || position < 0)
            {
                return;
            }
            else
            {
                NodeDL newNode = new NodeDL(e);

                var currentNode = head;
                int counter = 0;
                while (counter != position - 1)
                {
                    currentNode = currentNode.next;
                    counter++;
                }
                newNode.next = currentNode.next;
                newNode.previous = currentNode;
                currentNode.next = newNode;
                currentNode = newNode;
                size++;
            }



        }

        public void removeFirst()
        {
            if (isEmpty()) return;
            head = head.next;
            head.previous = null;
            size--;
        }

        public void removeLast()
        {
            if (isEmpty()) return;
            tail = tail.previous;
            tail.next = null;
            size--;
        }

        //time complexity > worst case O(n); space complexity = O(1)
        public void removeAtGivenPosition(int position)
        {
            if (isEmpty() || position < 0 || position > size)
            {
                return;
            }
            else if (position == 0)
            {
                removeFirst();
            }
            else if (position == length())
            {
                removeLast();
            }
            else
            {
                var currentNode = head;
                int counter = 0;
                while (counter != position - 1)
                {
                    currentNode = currentNode.next;
                    counter++;
                }
                var nextNode = currentNode.next;
                currentNode.next = nextNode.next;
                nextNode.previous = currentNode;
                size--;
            }
        }


        //time complexity = O(n); space complexity = O(1)
        public void removeDuplicates()
        {
            if (isEmpty()) return;

            var hasMap = new Dictionary<int, int>();
            var currentNode = head;
            int counter = 0;
            while (currentNode != null)
            {
                if (hasMap.ContainsKey(currentNode.element))
                {
                    removeAtGivenPosition(counter);
                    counter--;
                }
                else
                {
                    hasMap.Add(currentNode.element, counter);
                }
                currentNode = currentNode.next;
                counter++;
            }

        }

        //time complexity = O(n); space complexity = O(1)
        public void reverse_approach1()
        {
            if (isEmpty()) return;

            var currentNode = head;
            NodeDL prevNode = null;
            int counter = 0;
            while (currentNode != null)
            {
                var nextNode = currentNode.next;
                currentNode.next = prevNode;
                prevNode = currentNode;
                currentNode = nextNode;
                counter++;
            }
            head = prevNode;

        }
        public NodeDL reverseRecursively(NodeDL currentNode, NodeDL prevNode, int counter)
        {
            if (counter >= length()) return prevNode;
            var nextNode = currentNode.next;
            currentNode.next = prevNode;
            prevNode = currentNode;
            currentNode = nextNode;
            counter++;
            return reverseRecursively(currentNode, prevNode, counter);

        }

        //time complexity = O(n); space complexity = O(1)
        public void reverseLinkedListRecursively()
        {
            var currentNode = head;
            int counter = 0;
            head = reverseRecursively(currentNode, null, counter);
        }
        public int findElementbyPosition(int position)
        {

            if (isEmpty()) return -1;

            if (position < 0 || position > length()) return -1;

            var currentNode = head;
            int counter = 0;
            while (counter < length())
            {
                if (counter == position) return currentNode.element;
                currentNode = currentNode.next;
                counter++;
            }
            return -1;

        }
        public void reverseKGroupOnTheSameList(int k)
        {
            // input > 1-->2-->3-->4-->5-->6-->7-->
            //Result > 2 
            if (head == null || k == 1) return;


            var dummyNode = new NodeDL(0)
            {
                /// test
                next = head
            };

            var cur = dummyNode;
            var nex = dummyNode;
            var pre = dummyNode;

            int count = size;


            while (count >= k)
            {
                cur = pre.next;
                nex = cur.next;
                for (int i = 1; i < k; i++)
                {
                    cur.next = nex.next;
                    nex.next = pre.next;
                    pre.next = nex;
                    nex = cur.next;
                }
                pre = cur;
                count -= k;

                //display();

            }
            head = dummyNode.next;
            //tail.next = head;

        }


        public void reverseKGroupRecursively(int k, int size, NodeDL cur, NodeDL nex, NodeDL pre, NodeDL dummyNode)
        {
            // input > 1-->2-->3-->4-->5-->6-->7-->
            //Result > 2 
            if (head == null || k == 1) return;
            if (head != null && dummyNode == null)
            {
                dummyNode = new NodeDL(0)
                {
                    next = head
                };
                cur = dummyNode;
                nex = dummyNode;
                pre = dummyNode;

            }
            if (size < k)
            {
                head = dummyNode.next;
                return;
            }
            else
            {
                cur = pre.next;
                nex = cur.next;
                for (int i = 1; i < k; i++)
                {
                    cur.next = nex.next;
                    nex.next = pre.next;
                    pre.next = nex;
                    nex = cur.next;
                }
                pre = cur;
                size -= k;

            }


            reverseKGroupRecursively(k, size, cur, nex, pre, dummyNode);
        }


        public void display()
        {
            if (isEmpty()) return;

            var currentNode = head;

            while (currentNode != null)
            {
                System.Console.Write($"{currentNode.element} <-->");
                currentNode = currentNode.next;
            }
            System.Console.WriteLine();


        }

    }
}
