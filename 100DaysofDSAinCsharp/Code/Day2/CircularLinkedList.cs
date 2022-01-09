using _100DaysofDSAinCsharp.Code.Day1;
using System.Collections.Generic;

namespace _100DaysofDSAinCsharp.Code.Day2
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

        //time complexity O(1); space complexity O(1)
        public void addLast(int e)
        {
            Node newNode = new Node(e);

            if (isEmpty()) addFirst(e);

            newNode.next = tail.next;
            tail.next = newNode;
            tail = newNode;
            size++;
        }


        //time complexity = O(n); space complexity = O(1)
        public void addAnywhere(int e, int position)
        {

            if (isEmpty() || position == 0)
            {
                addFirst(e);
            }
            else
            {
                Node newNode = new Node(e);
                var currentNode = head;
                int counter = 0;
                while (counter < length())
                {
                    if (counter == position - 1)
                    {
                        newNode.next = currentNode.next;
                        currentNode.next = newNode;
                    }

                    currentNode = currentNode.next;
                    counter++;
                }
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
