using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 11, 3, 4, 1, 2, 9, 3, 7, 12, 6 };

            //MergeSorting.MergeSort(arr, 0, arr.Length - 1);
            //foreach (int val in arr)
            //{
            //    Console.Write($"{val}, ");
            //}

            QuickSorting.QuickSort(arr, 0, arr.Length - 1);
            foreach (int val in arr)
            {
                Console.Write($"{val}, ");
            }
        }
    }
}
