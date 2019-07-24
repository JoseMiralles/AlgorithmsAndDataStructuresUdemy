using System;

namespace AlgorithmsAndDataStructuresUdemy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CreateListAndLoop();
            Console.ReadLine();
        }

        public static void CreateListAndLoop()
        {
            SingleLinkedList<String> list = new SingleLinkedList<string>();
            for (int i = 0; i <= 10; i++)
            {
                list.Add("Node number " + i);
            }
            list.TraverseAndPrint();
        }
    }
}
