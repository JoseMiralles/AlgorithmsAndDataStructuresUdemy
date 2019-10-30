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

        public int Count { //TODO: Returning one more than answer.
            get { // O(n) implementation.
                Node<T> current = head;
                int count = 0;
                while (current != null)
                {
                    count++;
                    current = current.next;
                }
                return count;
            }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        /// <summary>
        /// Adds item at the end of the list. O(n) RT
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (head == null)
                head = new Node<T>(item);
            else
                GetLastItem().next = new Node<T>(item);
        }

        /// <summary>
        /// Inserts the given item at the start of the list. O(1) RT
        /// </summary>
        public void Prepend(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (head != null && head.next != null)
                newNode.next = head.next;
            this.head = newNode;
        }

        /// <summary>
        /// Returns the predecessor of the node containing the given item.
        /// </summary>
        /// <returns></returns>
        public Node<T> GetPredecessor(T item)
        {
            Node<T> current = head;
            if (current.data.Equals(item))
                return null; //The first item has no predecessor.
            while (current != null)
            {
                if (current.next.data.Equals(item))
                    return current; //Current is the predecessor.
            }
            return null; //Not found, return null.
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

        public void BubbleSort()
        {
            bool swapped = true;
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                //Return if no swapps happened in the last run beacuse it is already sorted.
                if (swapped == false) return;

                if (1 == current.data.CompareTo(current.next.data))
                { //The node is smaller, swap them.
                    if (current == head)
                    {
                        head = head.next;       // 2 is moved to 1
                        head.next = current;    // 1 is moved to 2
                    }
                    else
                    {
                        previous.next = current.next;
                        previous.next.next = current;
                    }
                }
                previous = current;
                current = current.next;
            }
        }

        /// <summary>
        /// Single linked node with a reference to the next item.
        /// </summary>
        public class Node<T1> where T1 : IComparable<T>
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
