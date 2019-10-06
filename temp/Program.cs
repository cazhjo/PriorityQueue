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
            que.Add(6);
            que.Add(7);

            Console.WriteLine(que.Peek());
            Console.WriteLine(que.Count());
            
        }
    }
}
