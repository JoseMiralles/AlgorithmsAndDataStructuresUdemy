using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructuresUdemy
{
    /// <summary>
    /// Single Linked list that implements the IList<T> interface.
    /// </summary>
    /// <typeparam name="T">The type to hold</typeparam>
    public class SingleLinkedList<T> : IList<T> where T : IComparable<T>
    {
        public Node<T> head;

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

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
        /// Adds the given item at the end of the list.
        /// </summary>
        /// <param name="item">Item to add.</param>
        public void Add(T item)
        {
            if (head == null)
                head = new Node<T>(item);
            else
            {
                Node<T> current = head;
                while (current != null)
                {
                    if (current.next == null)
                    {
                        current.next = new Node<T>(item);
                        return;
                    }
                    current = current.next;
                }
            }
        }

        /// <summary>
        /// Append an item at the end of the List.
        /// </summary>
        /// <param name="item">Item to append</param>
        public void Append(T item)
        {
            this.GetLastItem().next = new Node<T>(item);
        }

        public void Clear()
        {
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Node<T> GetLastItem()
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.next == null)
                    return current;
                current = current.next;
            }
            return current;
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
