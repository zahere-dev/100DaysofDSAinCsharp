using System.Collections.Generic;

namespace _100DaysofDSAinCsharp.src.Day10
{
    public class LruCache
    {
        //Constructing a Doubly Linkedlist Node
        public class LruNode
        {
            public int key, value;
            public LruNode prev, next;
            public LruNode(int _key, int _value)
            {
                key = _key;
                value = _value;
            }
        }


        //Create head and tail nodes with dummy key values
        private readonly LruNode head = new LruNode(0, 0);
        private readonly LruNode tail = new LruNode(0, 0);
        private readonly int capacity = 0;

        //Declare hasmap to store the address of the nodes
        private readonly Dictionary<int, LruNode> map = new Dictionary<int, LruNode>();

        //Define LrucCache's default values        
        public LruCache(int _capacity)
        {
            capacity = _capacity;
            head.next = tail;
            tail.next = head;
        }


        /// <summary>
        /// Get node value by given key else return -1
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int get(int key)
        {
            if (map.ContainsKey(key))
            {
                LruNode node = map[key];

                //Remove from current Position
                remove(node);

                //Insert right after head
                insert(node);
                return node.value;
            }
            return -1;

        }


        public void put(int key, int value)
        {
            if (map.ContainsKey(key))
            {
                remove(map[key]);
            }

            //if hasmap is full - remove the Least Recently used node - which is just before the tail
            if (map.Count == capacity)
            {
                remove(tail.prev);
            }

            insert(new LruNode(key, value));
        }

        private void insert(LruNode node)
        {
            map.Add(node.key, node);
            node.next = head.next;
            head.next.prev = node;
            head.next = node;
            node.prev = head;

        }

        private void remove(LruNode node)
        {
            map.Remove(node.key);
            node.prev.next = node.next;
            node.next.prev = node.prev;

        }
    }
}
