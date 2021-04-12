using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.Interfaces;

namespace April.Problems
{
    public class BeautifulArrangement2 : IProblem
    {
        public string Title => "Beautiful Arrangement II";
        public string Url => "https://leetcode.com/explore/challenge/card/april-leetcoding-challenge-2021/594/week-2-april-8th-april-14th/3705/";

        public int[] ConstructArray(int n, int k)
        {
            var ans = new int[n];
            var low = 1;
            var high = k + 1;

            for (var i = 0; i <= k; i++)
            {
                if (i % 2 == 0) ans[i] = low++;
                else ans[i] = high--;
            }

            for (var i = k + 1; i < n; i++)
            {
                ans[i] = i + 1;
            }

            return ans;
        }
    }
}
