using Shared.Interfaces;
using System;

namespace March.Problems
{
    public class BestTimeToBuyAndSellStockWithTransactionFee : IProblem
    {
        public string Title => "Best Time to Buy and Sell Stock with Transaction Fee";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/590/week-3-march-15th-march-21st/3674/";

        public int MaxProfit(int[] prices, int fee)
        {
            var maxProfit = 0;
            var stockOnHand = -prices[0];

            for (var i = 1; i < prices.Length; i++)
            {
                maxProfit = Math.Max(maxProfit, stockOnHand + prices[i] - fee);
                stockOnHand = Math.Max(stockOnHand, maxProfit - prices[i]);
            }

            return maxProfit;
        }
    }
}
