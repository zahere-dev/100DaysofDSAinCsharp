using _100DaysofDSAinCsharp.src.Day1;
using System.Collections.Generic;

namespace _100DaysofDSAinCsharp.src.Day2
{
    public class CircularLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public CircularLinkedList()
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

        //time complexity O(1); space complexity O(1)
        public void addFirst(int e)
        {
            Node newNode = new Node(e);

            if (isEmpty())
            {
                newNode.next = newNode;
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
                tail.next = newNode;
            }

            size++;
        }

        public int getFirst()
        {
            if (isEmpty()) return -1;
            return head.element;
        }


        //time complexity O(1); space complexity O(1)
        public void addLast(int e)
        {
            Node newNode = new Node(e);

            if (isEmpty())
            {
                addFirst(e);
            }
            else
            {
                newNode.next = tail.next;
                tail.next = newNode;
                tail = newNode;
                size++;
            }


        }


        //time complexity = O(n); space complexity = O(1)
        public void addAnywhere(int e, int position)
        {

            if (isEmpty() || position == 0)
            {
                addFirst(e);
            }
            else if (position > length() || position < 0)
            {
                return;
            }
            else
            {
                Node newNode = new Node(e);
                var currentNode = head;
                int counter = 0;
                while (counter != position - 1)
                {

                    currentNode = currentNode.next;
                    counter++;
                }
                newNode.next = currentNode.next;
                currentNode.next = newNode;
                size++;
            }
        }



        //time complexity = O(1); space complexity = O(1)
        public void removeLast()
        {
            if (isEmpty()) return;

            var currentNode = head;
            int counter = 0;
            while (counter < length() - 1)
            {
                currentNode = currentNode.next;
                counter++;
            }

            tail = currentNode.next;


            size--;
        }

        //time complexity = O(1); space complexity = O(1)
        public void removeFirst()
        {
            if (isEmpty()) return;

            head = head.next;
            tail.next = head;
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
                while (counter < length())
                {
                    if (counter == position - 1)
                    {
                        currentNode.next = currentNode.next.next;
                    }
                    currentNode = currentNode.next;
                    counter++;
                }
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
            while (counter < length())
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
            Node prevNode = null;
            int counter = 0;
            while (counter < length())
            {
                var nextNode = currentNode.next;
                currentNode.next = prevNode;
                prevNode = currentNode;
                currentNode = nextNode;
                counter++;
            }
            head = prevNode;

        }


        public Node reverseRecursively(Node currentNode, Node prevNode, int counter)
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


            var dummyNode = new Node(0)
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


        public void reverseKGroupByCreatingNewList(int k)
        {
            CircularLinkedList prevList = null;

            while (size > 0)
            {
                CircularLinkedList currentList = new CircularLinkedList();

                if (size >= k)
                {
                    for (int i = 0; i < k; i++)
                    {
                        int val = getFirst();
                        currentList.addFirst(val);
                        removeFirst();
                    }

                }
                else
                {
                    int s = length();
                    for (int i = 0; i < s; i++)
                    {
                        int val = getFirst();
                        currentList.addLast(val);
                        removeFirst();
                    }
                }

                if (prevList == null) prevList = currentList;
                else
                {
                    prevList.tail.next = currentList.head;
                    prevList.tail = currentList.tail;
                    prevList.size += currentList.size;
                }

            }

            head = prevList.head;
            tail = prevList.tail;
            size = prevList.length();
        }

        public void reverseKGroupRecursively(int k, int size, Node cur, Node nex, Node pre, Node dummyNode)
        {
            // input > 1-->2-->3-->4-->5-->6-->7-->
            //Result > 2 
            if (head == null || k == 1) return;
            if (head != null && dummyNode == null)
            {
                dummyNode = new Node(0)
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


        //time complexity O(n); space complexity O(1)
        public void display()
        {
            if (isEmpty()) return;

            Node currentNode = head;
            int counter = 0;
            while (counter < size)
            {
                System.Console.Write($"{currentNode.element}-->");
                currentNode = currentNode.next;
                counter++;
            }
            System.Console.WriteLine();
        }

    }
}
