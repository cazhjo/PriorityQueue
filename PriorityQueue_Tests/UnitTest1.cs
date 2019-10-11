using NUnit.Framework;
using PriorityQueueLibrary;
using System;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestThatAdd_Works()
        {
            PriorityQueue<int> que = new PriorityQueue<int>();
            que.Add(15);
            que.Add(14);
            que.Add(13);
            que.Add(12);
            que.Add(11);
            que.Add(10);
            que.Add(9);
            que.Add(8);
            que.Add(7);
            que.Add(6);
            que.Add(5);
            que.Add(4);
            que.Add(3);
            que.Add(2);
            que.Add(1);

            Assert.AreEqual(1, que.Peek());
        }

        [Test]
        public void TestThatPop_Works()
        {
            PriorityQueue<int> que = new PriorityQueue<int>();
            int[] poppedNumbers = new int[10];
            int[] expectedNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            que.Add(10);
            que.Add(9);
            que.Add(8);
            que.Add(7);
            que.Add(6);
            que.Add(5);
            que.Add(4);
            que.Add(3);
            que.Add(2);
            que.Add(1);

            for (int i = 0; i < poppedNumbers.Length; i++)
            {
                poppedNumbers[i] = que.Pop();
            }


            CollectionAssert.AreEqual(expectedNumbers, poppedNumbers);
            
        }

        [Test]
        public void TestThatPeek_OnEmptyQueue_ThrowsInvalidOperationException()
        {
            PriorityQueue<int> que = new PriorityQueue<int>();

            Assert.Throws<InvalidOperationException>(() => que.Peek());
            
        }

        [Test]
        public void TestThatPop_OnEmptyQueue_ThrowsInvalidOperationException()
        {
            PriorityQueue<int> que = new PriorityQueue<int>();

            Assert.Throws<InvalidOperationException>(() => que.Pop());

        }

        [Test]
        public void TestThatCount_OnEmptyQueue_ReturnsZero()
        {
            PriorityQueue<int> que = new PriorityQueue<int>();

            Assert.AreEqual(0, que.Count());
        }
    }
}