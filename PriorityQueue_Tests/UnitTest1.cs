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

            que.Pop();
            que.Pop();
            que.Pop();
            que.Pop();
            que.Pop();
            que.Pop();

            Assert.AreEqual(7, que.Pop());
            
        }

        [Test]
        public void TestThatPeek_OnEmptyList_ThrowsInvalidOperationException()
        {
            PriorityQueue<int> que = new PriorityQueue<int>();

            Assert.Throws<InvalidOperationException>(() => que.Peek());
            
        }

        [Test]
        public void TestThatPop_OnEmptyList_ThrowsInvalidOperationException()
        {
            PriorityQueue<int> que = new PriorityQueue<int>();

            Assert.Throws<InvalidOperationException>(() => que.Pop());

        }
    }
}