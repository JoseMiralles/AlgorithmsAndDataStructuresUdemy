using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructuresUdemy
{
    /// <summary>
    /// A single linked list with some common functionality.
    /// </summary>
    /// <typeparam name="T">Generic Type</typeparam>
    public class SingleLinkedListOld<T>
    {
        public Node<T> head;

        public SingleLinkedListOld(Node<T> head = null)
        {
            this.head = head;
        }

        public Node<T> Find(Node<T> item)
        {
            Node<T> current = this.head;
            while (current != null)
            {
                current = current.next;
                //TODO: Compare and return.
            }
            return null;
        }

        /// <summary>
        /// Traverses the list until the last item.
        /// </summary>
        /// <returns>The last item on the list. Or null if the list is empty</returns>
        public Node<T> GetLastItem()
        {
            Node<T> current = this.head;
            while (current != null)
            {
                current = current.next;
            }
            return current;
        }

        /// <summary>
        /// Traverses the whole list, and prints it's content.
        /// </summary>
        public void TraverseAndPrint()
        {
            if (head != null)
            {
                Node<T> current = head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
        }

        /// <summary>
        /// A single link node.
        /// </summary>
        public class Node<T>
        {
            public Node<T> next;
            public T data;

            public Node(T data, Node<T> next = null)
            {
                this.data = data;
                this.next = next;
            }

            /// <summary>
            /// Checks to see if the items are the same for comparable classes.
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="a">first item</param>
            /// <param name="b">second item</param>
            /// <returns></returns>
            public bool Equals<T>(T a, T b) where T : class
            {
                if (a == b)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Creates a single linked list with three items.
        /// </summary>
        public static void CreateLinkedListAndLoop()
        {
            SingleLinkedListOld<String> linkedList = new SingleLinkedListOld<String>();
            linkedList.head = new SingleLinkedListOld<String>.Node<String>("First");
            linkedList.head.next = new SingleLinkedListOld<String>.Node<String>("Second");
            linkedList.head.next.next = new SingleLinkedListOld<String>.Node<String>("Third");

            linkedList.TraverseAndPrint();
        }
    }

    /// <summary>
    /// Single Linked list that implements the IList<T> interface.
    /// </summary>
    /// <typeparam name="T">The type to hold</typeparam>
    public class SingleLinkedList<T> : IList<T>
    {
        public Node<T> head;

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        /// <summary>
        /// Traverses the whole list, and prints each item.
        /// </summary>
        public void TraverseAndPrint()
        {
            if (head == null)
            {
                Console.WriteLine("Single Linked List is empty!");
                return;
            }
            else
            {
                Node<T> current = head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
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

        public void Clear()
        {
            throw new NotImplementedException();
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

        /// <summary>
        /// Single linked node with a reference to the next item.
        /// </summary>
        public class Node<T>
        {
            public Node<T> next { get; set; }
            public T data { get; set; }

            /// <summary>
            /// Single link Node with a reference to the next node.
            /// </summary>
            /// <param name="data">Data to store</param>
            /// <param name="next">The next item on the list</param>
            public Node (T data, Node<T> next = null)
            {
                this.data = data;
                this.next = next;
            }
        }

    }
}
