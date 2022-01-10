using System.Collections.Generic;

namespace _100DaysofDSAinCsharp.src.Day2
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
