using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heaps
{
    class Program
    {
        static void Main(string[] args)
        {
            MinHeap minHeap = new MinHeap(10);
            minHeap.Insert(7);
            minHeap.Insert(2);
            minHeap.Insert(4);
            minHeap.Insert(1);
            minHeap.Insert(12);
            minHeap.Insert(8);

            Console.WriteLine("Min number now = " + minHeap.GetMin());
            Console.WriteLine("Min number now = " + minHeap.ExtractMin());
            Console.WriteLine("Min number now = " + minHeap.GetMin());

            Console.Read();

        }
    }

    class MinHeap
    {
        public int heapCapacity { get; set; }
        public int[] heap { get; set; }

        public int currentSize { get; set; }
        public MinHeap(int size)
        {
            heapCapacity = size;
            heap = new int[heapCapacity];
            currentSize = 0;
        }

        public int Parent(int i)
        {
            return (i - 1) / 2;
        }

        public int Left(int i)
        {
            return 2 * i + 1;
        }
        public int Right(int i)
        {
            return 2 * i + 2;
        }

        public bool Insert(int value)
        {
            if (currentSize >= heapCapacity)
            {
                return false;
            }

            int i = currentSize;
            heap[i] = value;
            currentSize++;

            while (i != 0 && heap[i] < heap[Parent(i)])
            {
                Swap(ref heap[i], ref heap[Parent(i)]);
                i = Parent(i);
            }
            return true;
        }

        private void Swap(ref int v1, ref int v2)
        {
            int t = v1;
            v1 = v2;
            v2 = t;
        }

        public int GetMin()
        {
            return heap[0];
        }

        public int ExtractMin()
        {
            if (currentSize <= 0)
            {
                return Int32.MaxValue;
            }

            if (currentSize == 1)
            {
                currentSize--;
                return heap[0];
            }

            int value = heap[0];
            heap[0] = heap[currentSize - 1];
            currentSize--;
            MinHeapify(0);

            return value;
        }

        public void MinHeapify(int index)
        {
            int smalllest = index;
            int l = Left(index);
            int r = Right(index);

            if (l < heapCapacity && heap[smalllest] > heap[l])
            {
                smalllest = l;
            }

            if (r < heapCapacity && heap[smalllest] > heap[r])
            {
                smalllest = r;
            }

            if (smalllest != index)
            {
                Swap(ref heap[smalllest], ref heap[index]);
                MinHeapify(smalllest);
            }
        }
    }
}
