using PriorityQueue;
using System;
using System.Collections.Generic;

namespace PriorityQueueLibrary
{
    public class PriorityQueue<T> : IPriorityQueue<T> where T : IComparable
    {
        private List<T> backingList;
        private int count = 0;

        public PriorityQueue()
        {
            backingList = new List<T>();
        }

        public void Add(T value)
        {
            count++;
            backingList.Add(value);
            SwitchPlacesIfNeeded();

        }

        public int Count()
        {
            return count;
        }

        public T Peek()
        {
            return backingList[0];
        }

        public T Pop()
        {
            T temp = backingList[0];
            backingList[0] = backingList[count - 1];
            backingList[count - 1] = default;
            count--;
            SwitchPlacesIfNeeded();
            return temp;
        }

        private void SwitchPlacesIfNeeded()
        {
            for (int i = count - 1; i >= 0; i--)
            {
                if (backingList[i].CompareTo(backingList[(i - 1)/2]) == -1)
                {
                    T temp = default;
                    temp = backingList[i];
                    backingList[i] = backingList[(i - 1)/2];
                    backingList[(i - 1)/ 2] = temp;

                }
            }
        }
    }
}
