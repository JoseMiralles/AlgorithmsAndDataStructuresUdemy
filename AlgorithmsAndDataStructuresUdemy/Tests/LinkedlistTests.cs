using System;
using NUnit.Framework;
using AlgorithmsAndDataStructuresUdemy;

namespace Tests
{
    [TestFixture]
    public class LinkedlistTests
    {
        [Test]
        public void GetLastItem()
        {
            SingleLinkedList<String> list = GetStringList(20);
            string lastItemString = list.GetLastItem().data;

            Assert.NotNull(lastItemString);
        }

        /// <summary>
        /// Creates and returns a SingleLinkedList full of strings.
        /// </summary>
        /// <param name="numberOfItems">Number of items to add.</param>
        /// <returns></returns>
        public static SingleLinkedList<String> GetStringList(int numberOfItems)
        {
            SingleLinkedList<String> list = new SingleLinkedList<String>();
            for (int i = 0; i <= numberOfItems; i++)
            {
                list.Add($"Item number {i}");
            }
            return list;
        }
    }
}
