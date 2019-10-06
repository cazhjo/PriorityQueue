using PriorityQueue;
using System;

namespace PriorityQueueLibrary
{
    public class PriorityQueue<T> : IPriorityQueue<T> where T : IComparable
    {
        private T[] backingArray;
        private int count = 0;

        public PriorityQueue()
        {
            backingArray = new T[count]; ;
        }

        public void Add(T value)
        {
            count++;
            ResizeIfNeeded();
            backingArray[Count() - 1] = value;
            SwitchPlacesIfNeeded();

        }

        public int Count()
        {
            return count;
        }

        public T Peek()
        {
            
            return backingArray[0];
        }

        public T Pop()
        {

            return backingArray[0];
        }

        private void ResizeIfNeeded()
        {
            T[] tempArray = null;

            if (count > backingArray.Length)
            {
                tempArray = new T[Count() + 1];

                for (int i = 0; i < backingArray.Length; i++)
                {
                    tempArray[i] = backingArray[i];
                }

                backingArray = tempArray;
            }
        }

        private void SwitchPlacesIfNeeded()
        {
            for (int i = count-1; i < 0; i--)
            {
                if (backingArray[i].CompareTo(backingArray[(i - 1)/2]) == -1)
                {
                    T temp = default;
                    temp = backingArray[i];
                    backingArray[i] = backingArray[(i - 1)/2];
                    backingArray[(i - 1)/ 2] = temp;

                }
            }
        }
    }
}
