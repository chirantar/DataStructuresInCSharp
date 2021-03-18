using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrrays
{
    internal class PrintAllPermutations
    {
        public void PrintPermutation(char[] s, int l, int r)
        {
            if (l == r)
            {
                Console.WriteLine(new string(s));
            }
            for (int i = l; i <= r; i++)
            {
                Swap(s, l, i);
                PrintPermutation(s, l + 1, r);
                Swap(s, l, i);
            }
        }

        private void Swap(char[] s, int l, int i)
        {
            char temp = s[l];
            s[l] = s[i];
            s[i] = temp;
        }
    }
}
