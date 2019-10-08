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
            return count != 0 ? backingList[0] : throw new InvalidOperationException("Cannot call Peek() on an empty list");
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Cannot call Pop() on an empty list");
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

            while (backingList[i].CompareTo(backingList[Parent(i)]) < 0) 
            {
                SwapTwoElements(i, Parent(i));

                i = Parent(i);
            }
        }

        private void BubbleDown()
        {

            if (count == 2)
            {
                if(backingList[0].CompareTo(backingList[1]) > 0)
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
            while (backingList[i].CompareTo(backingList[LeftChild(i)]) > 0 || backingList[i].CompareTo(backingList[RightChild(i)]) > 0)
            {
                if(backingList[LeftChild(i)].CompareTo(backingList[RightChild(i)]) < 0)
                {
                    SwapTwoElements(i, LeftChild(i));

                    i = LeftChild(i);
                }
                else
                {
                    SwapTwoElements(i, RightChild(i));
                    i = RightChild(i);
                }

                if(LeftChild(i) >= count || RightChild(i) >= count)
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

        private int Parent(int index)
        {
            return (index - 1) / 2;
        }

        private int LeftChild(int index)
        {
            return 2 * index + 1;
        }

        private int RightChild(int index)
        {
            return 2 * index + 2;
        }
    }
}



