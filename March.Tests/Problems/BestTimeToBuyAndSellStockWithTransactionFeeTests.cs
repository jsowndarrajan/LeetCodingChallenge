using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class BestTimeToBuyAndSellStockWithTransactionFeeTests
    {
        [TestCase(new[] { 1, 3, 2, 8, 4, 9 }, 2, 8)]
        [TestCase(new[] { 1, 3, 7, 5, 10, 3 }, 3, 6)]
        public void MaxProfit(int[] prices, int fee, int expected)
        {
            var sut = new BestTimeToBuyAndSellStockWithTransactionFee();
            var actual = sut.MaxProfit(prices, fee);
            Assert.AreEqual(expected, actual);
        }
    }
}
