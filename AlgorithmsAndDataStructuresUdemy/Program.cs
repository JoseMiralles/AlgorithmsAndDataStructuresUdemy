using System;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructuresUdemy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = GetList(40);


            Console.WriteLine();

            Console.Read();
        }

        public static SingleLinkedList<int> GetList(int nums)
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i <= nums; i++)
                list.Add(i);
            return list;
        }

        public static SingleLinkedList<int> GetUnsortedlist(int nums)
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            List<int> randomList = new List<int>();
            int rand = null;
            for (int i = 1; i<= nums; i++)
            {
                do

            }

            return list;
        }
    }
}
