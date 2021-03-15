using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Arrrays
{
    public class MergeSorting
    {
        public static void MergeSort(int[] array, int l, int r)
        {
            if (l < r)
            {
                int mid = (l + r) / 2;
                MergeSort(array, l, mid);
                MergeSort(array, mid + 1, r);
                Merge(array, l, mid, r);
            }

        }

        private static void Merge(int[] arr, int l, int m, int r)
        {
            int[] copy = new int[r - l + 1];


            int n1 = m + 1 - l;

            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            int i = 0, j = 0;
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[l + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[m + 1 + j];
            }
            int start = l;
            i = 0; j = 0;
            while (i < n1 && j < n2)
            {
                if (L[i] < R[j])
                {
                    arr[start] = L[i++];
                }
                else
                {
                    arr[start] = R[j++];
                }
                start++;
            }

            while (i < n1)
            {
                arr[start++] = L[i++];
            }
            while (j < n2)
            {
                arr[start++] = R[j++];
            }
        }
    }
}
