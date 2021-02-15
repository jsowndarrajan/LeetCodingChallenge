using Newtonsoft.Json;
using Shared.Helpers;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace February.Problems
{
    public class TheKWeakestRowsInAMatrix : IProblem
    {
        public string Title => "The K Weakest Rows in a Matrix";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/586/week-3-february-15th-february-21st/3641/";

        public string KWeakestRows(string input, string size)
        {
            try
            {
                if (!int.TryParse(size, out int k)) return Messages.InvalidInput;

                var mat = DataConverter.ConvertStringToNestedArray(input);
                var result = KWeakestRows(mat, k);
                return JsonConvert.SerializeObject(result);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int[] KWeakestRows(int[][] mat, int k)
        {
            var soldiers = new List<KeyValuePair<int, int>>();

            for (var i = 0; i < mat.Length; i++)
            {
                var count = 0;
                for (var j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1) count++;
                    else break;
                }

                soldiers.Add(new KeyValuePair<int, int>(i, count));
            }

            soldiers.Sort(new CustomComparer());

            var result = soldiers.Select(x => x.Key)
                                                .Take(k);
            return result.ToArray();
        }

        private class CustomComparer : IComparer<KeyValuePair<int,int>>
        {
            public int Compare(KeyValuePair<int, int> x, KeyValuePair<int, int> y)
            {
                if (x.Value < y.Value) return -1;
                if (x.Value > y.Value) return 1;
                if (x.Key < y.Key) return -1;
                return 1;
            }
        }
    }
}
