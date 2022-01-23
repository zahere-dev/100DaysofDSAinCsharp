namespace _100DaysofDSAinCsharp.src.Day12
{
    /// <summary>
    /// Setup node class that takes in value as input
    /// </summary>
    public class ListNode
    {
        public int value;
        public ListNode next;
        public ListNode prev;
        public ListNode(int val)
        {
            value = val;
            next = null;
            prev = null;
        }
    }

    public class LinkedList
    {
        public ListNode head;
        public ListNode tail;
        public int size;
        public LinkedList()
        {
            size = 0;
            head = null;
            tail = null;
        }

        //returns the length of the linkedlist
        public int length()
        {
            return size;
        }

        //returns true if linkelist size == 0
        public bool isEmpty()
        {
            return size == 0;
        }

        //Adds the new node as the new head
        public void addFirst(int val)
        {
            var newNode = new ListNode(val);
            //check for edge case - if head is empty make new node as head and tail
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            size++;
        }

        public void addAnywhere(int val, int position)
        {
            if (head == null || position <= 0 || position > length()) return;

            if (position == 1)
            {
                addFirst(val);
                return;
            }

            if (position == length())
            {
                addLast(val);
                return;
            }

            var currentNode = head;
            int counter = 1;
            while (counter < position - 1)
            {
                currentNode = currentNode.next;
                counter++;
            }

            var newNode = new ListNode(val)
            {
                next = currentNode.next
            };
            currentNode.next = newNode;
            size++;
        }

        //Adds a node at the end
        public void addLast(int val)
        {
            var newNode = new ListNode(val);
            if (head == null)
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

        public void removeFirst()
        {
            if (isEmpty()) return;
            head = head.next;
            size--;
        }

        public void removeAnywhere(int position)
        {
            if (head == null || position <= 0 || position > length()) return;

            if (position == 1)
            {
                removeFirst();
                return;
            }

            if (position == length())
            {
                removeLast();
                return;
            }

            var currentNode = head;
            int counter = 1;
            while (counter < position - 1)
            {
                currentNode = currentNode.next;
                counter++;
            }

            currentNode.next = currentNode.next.next;

            size--;

        }

        public void removeLast()
        {
            if (isEmpty()) return;

            var currentNode = head;
            int counter = 1;
            while (counter < length() - 1)
            {
                currentNode = currentNode.next;
                counter++;
            }
            currentNode.next = null;
            tail = currentNode;

            size--;
        }


        public void reverse()
        {
            if (isEmpty()) return;

            var currentNode = head;
            //create a dummy node
            ListNode prevNode = null;
            while (currentNode != null)
            {
                //capture the next node
                var nextNode = currentNode.next;
                //point nextnode to prevNode
                currentNode.next = prevNode;

                prevNode = currentNode;
                currentNode = nextNode;
            }

            head = prevNode;
        }


        public ListNode reverseList(ListNode node)
        {
            if (node == null) return node;

            var currentNode = node;
            //create a dummy node
            ListNode prevNode = null;
            while (currentNode != null)
            {
                //capture the next node
                var nextNode = currentNode.next;
                //point nextnode to prevNode
                currentNode.next = prevNode;

                prevNode = currentNode;
                currentNode = nextNode;
            }

            node = prevNode;

            return node;
        }


        private ListNode recursiveReverse(ListNode currentNode, ListNode prevNode, ListNode nextNode)
        {
            if (currentNode == null) return prevNode;
            nextNode = currentNode.next;
            currentNode.next = prevNode;
            prevNode = currentNode;
            currentNode = nextNode;
            return recursiveReverse(currentNode, prevNode, nextNode);
        }


        public void reverseRecursively()
        {
            if (isEmpty()) return;
            var currentNode = head;
            head = recursiveReverse(currentNode, null, null);
        }


        /// <summary>
        /// 1 -> 2 ->  3 -> 4 -> 5 -> 
        /// </summary>
        /// <param name="k">3</param>
        /// returns 3 -> 2 -> 1 -> 4 -> 5 -> 
        public void reverseKGroupOnTheSameList(int k)
        {
            //check for edge cases
            if (head == null || k <= 1) return;

            //create a dummy node 
            var dummyNode = new ListNode(0)
            {
                next = head
            };

            //create temporary nodes
            var curr = dummyNode;
            var prev = dummyNode;
            var next = dummyNode;

            //Get the size of the list
            int count = size;

            while (count >= k)
            {
                curr = prev.next;
                next = curr.next;

                for (int i = 1; i < k; i++)
                {
                    curr.next = next.next;
                    next.next = prev.next;
                    prev.next = next;
                    next = curr.next;
                }
                prev = curr;
                count -= k;
            }

            head = dummyNode.next;

        }


        /// <summary>
        ///1 -> 2 -> 3 -> 4 -> 5 -> 6- > 7 ->
        ///if k = 3
        ///first k items 1 -> 2 -> 3 - reversed 3 - > 2 - > 1
        /// second K items 4 -> 5 -> 6 revesed 6 -> 5 -> 4
        /// non K items - 7
        /// </summary> 
        /// <param name="k">3</param>
        /// returns 3 -> 2 -> 1 -> 6 -> 5 -> 4 -> 7
        public void reverseKGroupByCreatingNewList(int k)
        {
            //K items will be reversed and added to this - and the remaning non-K items will be appended as is
            LinkedList prevList = null;

            while (size > 0)
            {
                //temporary list that will only hold K items 
                LinkedList currentList = new LinkedList();


                // if size of the list is greater than K
                //Remove first item and add it to another list
                //Do this for K items
                // if list is 1 -> 2 -> 3 -> 4 -> 5 -> 6- >
                if (size >= k)
                {
                    for (int i = 0; i < k; i++)
                    {
                        int val = head.value;
                        currentList.addFirst(val);
                        removeFirst();
                    }

                }
                //add the non-k items at the end of the list
                else
                {
                    int s = length();
                    for (int i = 0; i < s; i++)
                    {
                        int val = head.value;
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
            size = prevList.size;
        }


        /// <summary>
        /// Node1: 1 -> 7 -> 8 -> 9 ->
        /// Node2: 9 -> 8 -> 7 ->
        /// Expected Result: 2 -> 7 -> 7 -> 6
        /// </summary>
        /// <param name="sl1">1 -> 7 -> 8 -> 9 -></param>
        /// <param name="sl2">9 -> 8 -> 7 -></param>
        /// <returns>2 -> 7 -> 7 -> 6</returns>
        public static LinkedList Add2ListsIterative(LinkedList sl1, LinkedList sl2)
        {
            //Create a dummy List to store the result
            var dummyList = new LinkedList();


            int carry = 0;

            //create tempNodes so that the head doesn't change
            var nodeOne = sl1.head;
            var nodeTwo = sl2.head;

            //Use 2 pointer method
            //Iterate until all nodes are null and carry is 0
            while (nodeOne != null || nodeTwo != null || carry != 0)
            {
                //capture value - ensure it's 0 if null
                int valueOne = nodeOne != null ? nodeOne.value : 0;
                int valueTwo = nodeTwo != null ? nodeTwo.value : 0;

                //capture the sum of nodes and crazy
                //first iteration carry will be 0
                int sumOfValues = valueOne + valueTwo + carry;

                //if sumOfValues is 16 then 16%10 = 6 
                int newValue = sumOfValues % 10;

                //add the newValut to the dummyList
                dummyList.addFirst(newValue);

                //Extract carry from sumOfValues by dividing it by 10 i.e. 16/10 = 1
                carry = sumOfValues / 10;

                //Move the pointer - handle the next pointer for null
                nodeOne = nodeOne != null ? nodeOne.next : null;
                nodeTwo = nodeTwo != null ? nodeTwo.next : null;

            }

            return dummyList;


        }



        /// <summary>
        /// Get middle of the node - Slow and Fast Pointer Method
        /// </summary>
        /// <param name="sl1">1 -> 2 -> 3 -> 4 -> 5 -> 6- ></param>
        /// <returns></returns>
        public static LinkedList MiddleOfLinkedListSlowAndFastPointerMethod(LinkedList sl1)
        {
            //Create 2 pointer Slow and Fast with given head
            var slow = sl1.head;
            var fast = sl1.head;

            //Iteratover both nodes until fast is null            
            while (fast != null)
            {
                //Fast will point to next of next - points 2 places ahead
                //meaning both slow and fast will start at 1
                //in the second iteration fast will point to 3 but slow will point to it's next node
                //when fast reaches the end slow will be in the middle
                fast = fast.next.next;
                slow = slow.next;
            }

            //return the slow node as head
            sl1.head = slow;
            return sl1;
        }



        public void display()
        {
            if (head == null) return;

            var currentNode = head;

            while (currentNode != null)
            {
                System.Console.Write($"{currentNode.value} -> ");
                currentNode = currentNode.next;
            }
            System.Console.WriteLine();


        }


    }
}
