using Shared.Interfaces;
using System;

namespace March.Problems
{
    public class RussianDollEnvelopes : IProblem
    {
        public string Title => "Russian Doll Envelopes";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/592/week-5-march-29th-march-31st/3690/";

        public int MaxEnvelopes(int[][] envelopes)
        {
            var lis = new int[envelopes.Length];
            Array.Sort(envelopes, (x, y) =>
            {
                if (x[0] != y[0]) return x[0] - y[0];
                return x[1] - y[1];
            });

            var output = 0;
            for (var i = 0; i < envelopes.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    if (envelopes[j][0] < envelopes[i][0] && envelopes[j][1] < envelopes[i][1] &&
                        lis[i] < lis[j] + 1)
                    {
                        lis[i] = lis[j] + 1;
                        output = Math.Max(output, lis[i]);
                    }
                }
            }
            return output + 1;
        }
    }
}
