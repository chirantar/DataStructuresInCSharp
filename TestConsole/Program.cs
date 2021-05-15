using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]{10, 9, 8 , 7, 6, 5,4, 3, 2, 1 };
            //Merge obj = new Merge();
            //obj.MergeSort(arr, 0, arr.Length - 1);

            //QS obj = new QS();
            //obj.QuickSort(arr, 0, arr.Length - 1);

            //foreach (int ele in arr)
            //{
            //    Console.WriteLine($"{ele}, ");
            //}
            Solution sol = new Solution();
            List<string> ans = sol.LetterCombinations("23").ToList();

            Console.Read();
        }
    }
    public class Solution
    {
        Dictionary<char, string> dict = new Dictionary<char, string>()
        {
            {'2', "abc"}, {'3', "def"}, {'4', "ghi"},
            {'5',"jkl"}, {'6', "mno"},
            {'7', "pqrs"}, {'8', "tuv"}, {'9', "wzyz"}
        };

        List<string> output = new List<string>();

        public IList<string> LetterCombinations(string digits)
        {
            if (digits == "")
            {
                return new List<string>();
            }

            LetterCombUtil(new StringBuilder(), digits, 0, digits.Length);
            return output;
        }

        public void LetterCombUtil(StringBuilder path, string input, int index, int length)
        {
            if (path.Length == length)
            {
                output.Add(path.ToString());
                return;
            }

            string s = dict[input[index]];
            for (int j = 0; j < s.Length; j++)
            {
                path.Append(s[j]);
                LetterCombUtil(path, input, index + 1, length);
                path.Remove(path.Length - 1, 1);
            }
        }

        class QS
        {
            public void QuickSort(int[] arr, int si, int ei)
            {
                if (si >= ei)
                {
                    return;
                }

                int c = Partition(arr, si, ei);
                QuickSort(arr, si, c - 1);
                QuickSort(arr, c + 1, ei);
            }

            private int Partition(int[] arr, int si, int ei)
            {
                int p = arr[si];

                int i = si +1;
                int j = ei;

                while (i < j)
                {
                    while (i <= ei && arr[i] < p)
                    {
                        i++;
                    }
                    while (j > si && arr[j] >= p)
                    {
                        j--;
                    }
                    if (i < j)
                    {
                        Swap(arr, i, j);
                        i++; j--;
                    }
                }
                Swap(arr, si, j);

                return j;
            }
            private void Swap(int[] s, int l, int i)
            {
                int temp = s[l];
                s[l] = s[i];
                s[i] = temp;
            }
        }

        class Merge
        {
            public void MergeSort(int[] arr, int si, int ei)
            {
                if (ei <= si)
                    return;

                int mid = si + (ei - si)/2;

                MergeSort(arr, si, mid);
                MergeSort(arr, mid + 1, ei);
                MergeArray(arr, si, mid, ei);
            }

            private void MergeArray(int[] arr, int si, int mid, int ei)
            {
                int[] temp = new int[ei-si +1];
                int i = 0;

                int n1 = si, n2=mid+1;

                while (n1 <= mid && n2 <= ei)
                {
                    if (arr[n1] < arr[n2])
                    {
                        temp[i++] = arr[n1++];
                    }
                    else
                    {
                        temp[i++] = arr[n2++];
                    }
                }

                while (n1 <= mid)
                {
                    temp[i++] = arr[n1++];
                }

                while (n2 <= ei)
                {
                    temp[i++] = arr[n2++];
                }
                n1 = si;
                for (int j = 0; j < (ei - si + 1); j++)
                {
                    arr[n1++] = temp[j];
                }
            }
        }
    }
}
