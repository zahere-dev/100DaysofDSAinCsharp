﻿using System;
using System.Collections.Generic;

namespace _100DaysofDSAinCsharp.src.Day1
{
    public class SinglyLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public SinglyLinkedList()
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


        //time complexity = O(1); space complexity = O(1)
        public void addLast(int e)
        {
            Node newNode = new Node(e);

            if (isEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            size++;
        }

        //time complexity = O(1); space complexity = O(1)
        public void addFirst(int e)
        {
            Node newNode = new Node(e);

            if (isEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;

            }
            size++;

        }

        //time complexity = O(n); space complexity = O(1)
        public void addAnywhere(int e, int position)
        {
            Node newNode = new Node(e);
            if (isEmpty() || position == 0)
            {
                addFirst(position);
            }
            else
            {
                var currentNode = head;
                int counter = 0;
                while (currentNode != null)
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
            while (currentNode != null)
            {
                if (counter == size - 1)
                {
                    currentNode.next = null;
                    tail = currentNode;
                    break;
                }
                currentNode = currentNode.next;
                counter++;
            }
            size--;

        }

        //time complexity = O(1); space complexity = O(1)
        public void removeFirst()
        {
            if (isEmpty()) return;
            head = head.next;
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
            else
            {
                var currentNode = head;
                int counter = 0;
                while (currentNode != null)
                {
                    if (counter == position - 1)
                    {
                        currentNode.next = currentNode.next.next;
                        break;
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
            if (!isEmpty())
            {
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

        }

        //time complexity = O(n); space complexity = O(1)
        public void reverse_approach1()
        {
            if (!isEmpty())
            {
                var currentNode = head;
                Node prevNode = null;
                while (currentNode != null)
                {
                    var nextNode = currentNode.next;
                    currentNode.next = prevNode;
                    prevNode = currentNode;
                    currentNode = nextNode;
                }
                head = prevNode;
            }
        }

        private Node reverseRecursively(Node current, Node previous)
        {
            if (current == null) return previous;
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
            return reverseRecursively(current, previous);
        }

        public void reverseLinkedListRecursively()
        {
            var currentNode = head;
            head = reverseRecursively(currentNode, null);
        }



        //returns the position of first matching element
        public int findElementByValue(int element)
        {
            int counter = 0;
            if (!isEmpty())
            {
                var currentNode = head;

                while (currentNode != null)
                {
                    if (currentNode.element == element) return counter;
                    currentNode = currentNode.next;
                    counter++;

                }

            }

            return -1;
        }


        private bool recursiveFunc(int elementToFind, Node node)
        {
            if (node == null) return false;
            if (node.element == elementToFind) return true;

            return recursiveFunc(elementToFind, node.next);
        }

        public bool findElementByValueRecursively(int elementToFind)
        {
            return recursiveFunc(elementToFind, head);
        }

        //returns the value of first matching element
        public int findElementbyPosition(int position)
        {
            int counter = 0;
            if (!isEmpty())
            {
                var currentNode = head;
                while (currentNode != null)
                {
                    if (counter == position) return currentNode.element;
                    currentNode = currentNode.next;
                    counter++;
                }
            }
            return -1;
        }


        public void insertingElementsInSortedOrder(int e)
        {

            if (isEmpty())
            {
                return;
            }

            if (size == 0 && e <= head.element)
            {
                addFirst(e);
                return;
            }

            var currentNode = head;
            int counter = 0;
            while (currentNode != null)
            {
                if (e <= currentNode.element)
                {
                    addAnywhere(e, counter);
                    counter++;
                }
                currentNode = currentNode.next;
                counter++;
            }

        }

        //time complexity = O(n); space complexity = O(1)
        public void display()
        {
            if (!isEmpty())
            {
                var currentNode = head;
                while (currentNode != null)
                {
                    Console.Write($"{currentNode.element}-->");
                    currentNode = currentNode.next;

                }
                Console.WriteLine();
            }

        }

    }
}
