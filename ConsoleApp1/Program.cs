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


            PriorityQueueTester.TestPriorityQueue(() => new PriorityQueue<int>(), () => new PriorityQueue<string>());
        }
    }
}
