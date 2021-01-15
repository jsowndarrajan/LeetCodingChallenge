using System;
using Shared.Helpers;
using Shared.Interfaces;

namespace January.Problems
{
    public class GetMaximumInGeneratedArray : IProblem
    {
        public string Title => "Get Maximum in Generated Array";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/581/week-3-january-15th-january-21st/3605/";

        public string GetMaximumGenerated(string input)
        {
            try
            {
                if (int.TryParse(input, out var n))
                {
                    return GetMaximumGenerated(n).ToString();
                }
                return Messages.InvalidInput;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int GetMaximumGenerated(int n)
        {
            if (n < 2) return n;
            var generatedArray = new int[n + 1];
            generatedArray[1] = 1;

            var max = 1;
            for (var i = 2; i <= n; i++)
            {
                var headIndex = i / 2;
                generatedArray[i] = generatedArray[headIndex];
                if (i % 2 != 0)
                {
                    generatedArray[i] += generatedArray[headIndex + 1];
                }
                max = Math.Max(max, generatedArray[i]);
            }
            return max;
        }
    }
}
