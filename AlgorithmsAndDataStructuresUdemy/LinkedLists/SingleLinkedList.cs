using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructuresUdemy
{
    /// <summary>
    /// Single Linked list that implements the IList<T> interface.
    /// </summary>
    /// <typeparam name="T">The type to hold</typeparam>
    public class SingleLinkedList<T> : ICollection<T> where T : IComparable<T>
    {
        public Node<T> head = null;

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        /// <summary>
        /// Adds item at the end of the list.
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (head == null)
                head = new Node<T>(item);
            else
                GetLastItem().next = new Node<T>(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks if the item is on the list.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            if (head == null) return false;

            Node<T> current = head;
            while (current != null)
            {
                if (current.data.Equals(item))
                    return true;
                current = current.next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Node<T> current = head;
            while (current != null)
            {
                array[arrayIndex] = current.data;
                current = current.next;
                arrayIndex++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public Node<T> Get(T item)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.data.Equals(item))
                    return current;
                current = current.next;
            }
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Node<T> GetLastItem()
        {
            if (head == null) return null;
            Node<T> current = head;
            while (current.next != null)
                current = current.next;
            return current;
        }

        /// <summary>
        /// Traverses the whole list, and prints each item.
        /// </summary>
        public bool TraverseAndPrint()
        {
            if (head == null)
            {
                Console.WriteLine("Single Linked List is empty!");
                return false;
            }
            else
            {
                Node<T> current = head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
                return true;
            }
        }

        /// <summary>
        /// Single linked node with a reference to the next item.
        /// </summary>
        public class Node<T1> where T1 : IComparable<T1>
        {
            public Node<T1> next { get; set; }
            public T1 data { get; set; }

            /// <summary>
            /// Single link Node with a reference to the next node.
            /// </summary>
            /// <param name="data">Data to store</param>
            /// <param name="next">The next item on the list</param>
            public Node (T1 data, Node<T1> next = null)
            {
                this.data = data;
                this.next = next;
            }
        }

    }
}
