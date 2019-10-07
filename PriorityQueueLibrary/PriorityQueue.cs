using PriorityQueue;
using System;
using System.Collections.Generic;

namespace PriorityQueueLibrary
{
    public class PriorityQueue<T> : IPriorityQueue<T> where T : IComparable, IComparable<T>
    {
        private List<T> backingList;
        private int count = 0;

        public PriorityQueue()
        {
            backingList = new List<T>();
        }

        public void Add(T value)
        {
            if (!(value.CompareTo(default) == -1))
            {
                count++;
                backingList.Add(value);
                SwitchPlacesIfNeeded();
            }
            else
            {
                return;
            }

        }

        public int Count()
        {
            return count;
        }

        public T Peek()
        {
            return count != 0 ? backingList[0] : (default);
        }

        public T Pop()
        {
            if (count == 0)
            {
                return default;
            }
            else
            {
                T temp = default;
                temp = backingList[0];
                backingList[0] = backingList[count - 1];
                backingList.RemoveAt(count - 1);
                count--;
                SwitchPlacesIfNeeded();
                return temp;
            }

            
        }

        private void SwitchPlacesIfNeeded()
        {
            for (int i = count - 1; i >= 0; i--)
            {
                if (backingList[i].CompareTo(backingList[(i - 1) / 2]) == -1)
                {
                    T temp = default;
                    temp = backingList[i];
                    backingList[i] = backingList[(i - 1) / 2];
                    backingList[(i - 1) / 2] = temp;

                }
            }
        }
    }
}
