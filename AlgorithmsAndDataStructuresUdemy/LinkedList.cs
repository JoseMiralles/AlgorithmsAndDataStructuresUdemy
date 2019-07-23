using System;
namespace AlgorithmsAndDataStructuresUdemy
{
    public class LinkedList
    {
        public Node head;

        public LinkedList(Node head = null)
        {
            this.head = head;
        }

        public void TraverseAndPrint()
        {
            if (head != null)
            {
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
        }

        public class Node
        {
            public Node next;
            public string data;

            public Node (string data, Node next = null)
            {
                this.data = data;
                this.next = next;
            }
        }
    }
}
