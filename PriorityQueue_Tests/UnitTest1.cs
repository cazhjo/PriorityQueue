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
    }
}