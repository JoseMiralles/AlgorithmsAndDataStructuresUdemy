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
            LinkedList linkedList = new LinkedList();
            linkedList.head = new LinkedList.Node("First");
            linkedList.head.next = new LinkedList.Node("Second");
            linkedList.head.next.next = new LinkedList.Node("Third");

            linkedList.TraverseAndPrint();
        }
    }
}
