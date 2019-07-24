using System;
namespace AlgorithmsAndDataStructuresUdemy
{
    /// <summary>
    /// A single linked list with some common functionality.
    /// </summary>
    /// <typeparam name="T">Generic Type</typeparam>
    public class SingleLinkedList<T>
    {
        public Node<T> head;

        public SingleLinkedList(Node<T> head = null)
        {
            this.head = head;
        }

        public Node<T> Find(Node<T> item)
        {
            Node<T> current = this.head;
            while (current != null)
            {
                current = current.next;
                if (current.Equals<T>(current.data, item))
                    return current;
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

            public Node (T data, Node<T> next = null)
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
            SingleLinkedList<String> linkedList = new SingleLinkedList<String>();
            linkedList.head = new SingleLinkedList<String>.Node<String>("First");
            linkedList.head.next = new SingleLinkedList<String>.Node<String>("Second");
            linkedList.head.next.next = new SingleLinkedList<String>.Node<String>("Third");

            linkedList.TraverseAndPrint();
        }
    }
}
