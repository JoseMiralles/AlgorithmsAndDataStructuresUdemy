using System;
using NUnit.Framework;
using AlgorithmsAndDataStructuresUdemy;

namespace Tests
{
    [TestFixture]
    public class LinkedlistTests
    {
        [Test]
        public void TestContains()
        {
            SingleLinkedList<int> list = GetIntList(30);
            Assert.IsTrue(list.Contains(25));
        }

        [Test]
        public void TestCount()
        {
            SingleLinkedList<int> list = GetIntList(30);
            Assert.AreEqual(30, list.Count);
        }

        #region helper section
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
                list.Add($"Item number {i}.");
            }
            return list;
        }

        public static SingleLinkedList<int> GetIntList(int numberOfItems)
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i<=numberOfItems;i++)
            {
                list.Add(i);
            }
            return list;
        }
        #endregion
    }
}
