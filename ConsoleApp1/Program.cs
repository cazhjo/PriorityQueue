using System;
using IPriorityQueue;
using PriorityQueueLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PriorityQueue<int> que = new PriorityQueue<int>();
            //que.Add(10);
            //que.Add(9);
            //que.Add(8);
            //que.Add(7);
            //que.Add(6);
            //que.Add(5);
            //que.Add(4);
            //que.Add(3);
            //que.Add(2);
            //que.Add(1);

            //que.Pop();
            //que.Pop();
            //que.Pop();
            //que.Pop();



            PriorityQueueTester.TestPriorityQueue(() => new PriorityQueue<int>(), () => new PriorityQueue<string>());
        }
    }
}
