using System;

namespace AlgorithmsAndDataStructuresUdemy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CreateLinkedListAndLoop();
            Console.ReadLine();
        }

        public static void CreateLinkedListAndLoop()
        {
            SingleLinkedList linkedList = new SingleLinkedList();
            linkedList.head = new SingleLinkedList.Node("First");
            linkedList.head.next = new SingleLinkedList.Node("Second");
            linkedList.head.next.next = new SingleLinkedList.Node("Third");

            linkedList.TraverseAndPrint();
        }
    }
}
