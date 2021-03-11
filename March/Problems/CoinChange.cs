using Shared.Interfaces;
using System;

namespace March.Problems
{
    public class CoinChange : IProblem
    {
        public string Title => "Coin Change";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/589/week-2-march-8th-march-14th/3668/";

        public int Calculate(int[] coins, int amount)
        {
            var dp = new int[amount + 1];
            var max = 100000;
            for (var i = 1; i <= amount; i++)
            {
                dp[i] = max;
            }

            for (var i = 1; i <= coins.Length; i++)
            {
                for (var j = 1; j <= amount; j++)
                {
                    var remainder = j - coins[i - 1];
                    if (remainder >= 0)
                    {
                        dp[j] = Math.Min(1 + dp[remainder], dp[j]);
                    }
                }
            }
            return dp[amount] >= 100000 ? -1 : dp[amount];
        }
    }
}
