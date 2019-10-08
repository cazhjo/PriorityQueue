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
            count++;
            backingList.Add(value);
            BubbleUp();
        }

        public int Count()
        {
            return count;
        }

        public T Peek()
        {
            return count != 0 ? backingList[0] : throw new InvalidOperationException("Cannot call Peek on an empty list");
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Cannot call Pop on an empty list");
            }
            else
            {
                T temp = backingList[0];
                backingList[0] = backingList[count - 1];
                backingList.RemoveAt(count - 1);
                count--;
                BubbleDown();
                return temp;
            }


        }

        private void BubbleUp()
        {
            int i = count - 1;

            while (backingList[i].CompareTo(backingList[(i - 1) / 2]) == -1) 
            {
                SwapTwoElements(i, (i - 1) / 2);

                i = (i - 1) / 2;
            }
        }

        private void BubbleDown()
        {

            if (count == 2)
            {
                if(backingList[0].CompareTo(backingList[1]) == 1)
                {
                    SwapTwoElements(0, 1);
                    return;
                }
                else
                {
                    return;
                }
            }
            else if(count <= 1)
            {
                return;
            }

            int i = 0;
            while (backingList[i].CompareTo(backingList[2 * i + 1]) == 1 || backingList[i].CompareTo(backingList[2 * i + 2]) == 1)
            {
                if(backingList[2 * i + 1].CompareTo(backingList[2 * i + 2]) == -1)
                {
                    SwapTwoElements(i, 2 * i + 1);

                    i = 2 * i + 1;
                }
                else
                {
                    SwapTwoElements(i, 2 * i + 2);
                    i = 2 * i + 2;
                }

                if(2 * i + 1 >= count || 2 * i + 2 >= count)
                {
                    break;
                }
            }
            
        }

        private void SwapTwoElements(int index1, int index2)
        {
            T temp = backingList[index1];
            backingList[index1] = backingList[index2];
            backingList[index2] = temp;
        }
    }
}



