using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LRUCache
{
    class Program
    {
        static void Main(string[] args)
        {
            LRUCache cache = new LRUCache(4);
            cache.Refer(1);
            cache.Refer(2);
            cache.Refer(3);
            cache.Refer(1);
            cache.Refer(4);
            cache.Refer(5);
            cache.Refer(2);
            cache.Refer(2);
            cache.Refer(1);
            cache.Display();
        }
    }

    class LRUCache
    {
        int mCapacity;
        LinkedList<int> mDoublyQueue;
        HashSet<int> mHashSet;
        int[] arr = new int[10];


        public LRUCache(int size)
        {
            mCapacity = size;
            mDoublyQueue = new LinkedList<int>();
            mHashSet = new HashSet<int>();
        }

        public void Refer(int page)
        {
            if (mHashSet.Contains(page) == false)
            {
                if (mDoublyQueue.Count == mCapacity)
                {
                    int val = mDoublyQueue.Last.Value;
                    mDoublyQueue.RemoveLast();
                    mHashSet.Remove(val);
                }
            }
            else
            {
                mDoublyQueue.Remove(page);
            }

            mDoublyQueue.AddFirst(page);
            mHashSet.Add(page);
        }

        public void Display()
        {
            foreach (int i in mDoublyQueue)
            {
                Console.WriteLine(i);
            }
        }
    }
}
