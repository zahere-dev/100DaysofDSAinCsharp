﻿using System;
using System.Collections.Generic;

namespace _100DaysofDSAinCsharp.Code.Day1
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

        public bool isEmtpty()
        {
            return size == 0;
        }


        //time complexity = O(1); space complexity = O(1)
        public void addLast(int e)
        {
            Node newNode = new Node(e);

            if (isEmtpty())
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

            if (isEmtpty())
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
            if (isEmtpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                var currentNode = head;
                int counter = 0;
                while (counter != 0)
                {
                    currentNode = currentNode.next;
                    counter++;
                }
            }
        }

        //time complexity = O(1); space complexity = O(1)
        public void removeLast()
        {
            if (!isEmtpty())
            {
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
        }

        //time complexity = O(1); space complexity = O(1)
        public void removeFirst()
        {
            if (!isEmtpty())
            {
                head = head.next;
                size--;
            }
        }

        //time complexity > worst case O(n); space complexity = O(1)
        public void removeAtGivenPosition(int position)
        {
            if (isEmtpty() || position < 0 || position > size)
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
            if (!isEmtpty())
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
            if (!isEmtpty())
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

        //time complexity = O(n); space complexity = O(1)
        public void display()
        {
            if (!isEmtpty())
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