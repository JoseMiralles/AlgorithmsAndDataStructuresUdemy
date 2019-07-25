using System;

namespace AlgorithmsAndDataStructuresUdemy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = getList(40);
            Console.WriteLine(list.Contains(25));
            Console.WriteLine(list.Contains(55));

            Console.WriteLine(list.Get(30).data);

            Console.Read();
        }

        public static SingleLinkedList<int> getList(int nums)
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i <= nums; i++)
                list.Add(i);
            return list;
        }
    }
}
