using NUnit.Framework;
using PriorityQueueLibrary;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            PriorityQueue<int> que = new PriorityQueue<int>();
            que.Add(1);
            que.Add(2);
            que.Add(3);
            que.Add(4);

            Assert.AreEqual(4, que.Count());
        }

        [Test]
        public void Test2()
        {
            PriorityQueue<int> que = new PriorityQueue<int>();
            que.Add(9);
            que.Add(8);
            que.Add(7);
            que.Add(6);
            que.Add(5);
            que.Add(4);
            que.Add(3);
            que.Add(2);

            que.Pop();

            Assert.IsTrue(que.Pop() == 3);
        }

    }
}