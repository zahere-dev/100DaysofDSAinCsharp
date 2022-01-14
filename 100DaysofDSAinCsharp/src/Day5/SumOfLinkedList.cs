using _100DaysofDSAinCsharp.src.Day1;

namespace _100DaysofDSAinCsharp.src.Day5
{
    public class SumOfLinkedList
    {

        public static SinglyLinkedList AddTwoListRecursively(SinglyLinkedList sl1, SinglyLinkedList sl2)
        {
            SinglyLinkedList res = new SinglyLinkedList();

            int oc = AddListHelper(sl1.head, sl1.length(), sl2.head, sl2.length(), res);

            if (oc > 0)
            {
                res.addFirst(oc);
            }

            return res;
        }

        private static int AddListHelper(Node node1, int v1, Node node2, int v2, SinglyLinkedList res)
        {
            if (node1 == null && node2 == null)
            {
                return 0;
            }

            int data = 0;
            if (v1 > v2)
            {
                int oc = AddListHelper(node1.next, v1 - 1, node2, v2, res);
                data = node1.element + oc;

            }
            else if (v1 < v2)
            {
                int oc = AddListHelper(node1, v1, node2.next, v2 - 1, res);
                data = node2.element + oc;
            }
            else
            {
                int oc = AddListHelper(node1.next, v1 - 1, node2.next, v2 - 1, res);

                data = node1.element + node2.element + oc;

            }
            int nd = data % 10;
            int nc = data / 10;

            res.addFirst(nd);
            return nc;
        }

        //private static int AddTwoListIteratively(SinglyLinkedList sl1, SinglyLinkedList sl2)
        //{
        //    SinglyLinkedList res = new SinglyLinkedList();

        //    var node1 = sl1.head;
        //    var node2 = sl2.head;
        //    int v1 = sl1.size;
        //    int v2 = sl2.size;


        //    while (node1 == null && node2 == null)
        //    {              

        //        int data = 0;
        //        if (v1 > v2)
        //        {
        //            node1 = node1.next;
        //            v1--;
        //        }
        //        else if (v1 < v2)
        //        {
        //            node2 = node2.next;
        //            v2--;
        //        }
        //        else if (v1 == v2)
        //        {


        //            data = node1.element + node2.element + oc;
        //        }
        //        else
        //        {
        //            data = node1.element + node2.element + oc;
        //            int nd = data % 10;
        //            int nc = data / 10;
        //        }



        //        res.addFirst(nd);
        //        return nc;
        //    }


        //}

        public static SinglyLinkedList Add2ListsIterative(SinglyLinkedList sl1, SinglyLinkedList sl2)
        {
            var dummyList = new SinglyLinkedList();
            var dummyNode = new Node(0);
            var currentNode = dummyNode;
            int carry = 0;

            var nodeOne = sl1.head;
            var nodeTwo = sl2.head;

            while (nodeOne != null || nodeTwo != null || carry != 0)
            {
                int valueOne = nodeOne != null ? nodeOne.element : 0;
                int valueTwo = nodeTwo != null ? nodeTwo.element : 0;

                int sumOfValues = valueOne + valueTwo + carry;

                int newValue = sumOfValues % 10;

                dummyList.addFirst(newValue);

                carry = sumOfValues / 10;

                nodeOne = nodeOne != null ? nodeOne.next : null;
                nodeTwo = nodeTwo != null ? nodeTwo.next : null;

            }

            return dummyList;


        }


    }
}