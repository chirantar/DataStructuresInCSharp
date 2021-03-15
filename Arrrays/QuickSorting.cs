using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrrays
{
    public class QuickSorting
    {
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int p = arr[low];
            int s = low + 1;
            int l = high;
            while (s < l)
            {
                while (s < high && arr[s] <= p)
                {
                    s++;
                }
                while (l > low && arr[l] > p)
                {
                    l--;
                }

                if (s < l)
                {
                    Swap(arr, s, l);
                    s++;
                    l--;
                }
            }

            Swap(arr, low, l);
            return l;
        }

        private static void Swap(int[] arr, int s, int l)
        {
            int temp = arr[s];

            arr[s] = arr[l];

            arr[l] = temp;
        }
    }
}
