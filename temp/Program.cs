using PriorityQueueLibrary;
using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<int> que = new PriorityQueue<int>();
            que.Add(5);
            que.Add(4);
            que.Add(7);
            que.Add(6);
            que.Add(2);
            que.Add(1);
            que.Add(2);

            que.Pop();
            que.Pop();
            que.Pop();

            Console.WriteLine(que.Peek());
            Console.WriteLine(que.Count());


        }
    }
}
