using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class BinaryTreesWithFactorsTests
    {
        [TestCase(new[] { 2 },  1)]
        [TestCase(new[] { 2, 4 },  3)]
        [TestCase(new[] { 2, 4, 8 },  8)]
        [TestCase(new[] { 2, 4, 8, 16},  23)]
        [TestCase(new[] { 2, 4 },  3)]
        [TestCase(new[] { 2, 4, 5, 10 },  7)]
        [TestCase(new[] { 18, 3, 6, 2 },  12)]
        [TestCase(new[] { 45, 42, 2, 18, 23, 1170, 12, 41, 40, 9, 47, 24, 33, 28, 10, 32, 29, 17, 46, 11, 759, 37, 6, 26, 21, 49, 31, 14, 19, 8, 13, 7, 27, 22, 3, 36, 34, 38, 39, 30, 43, 15, 4, 16, 35, 25, 20, 44, 5, 48 },  777)]
        [TestCase(new[] { 46, 144, 5040, 4488, 544, 380, 4410, 34, 11, 5, 3063808, 5550, 34496, 12, 540, 28, 18, 13, 2, 1056, 32710656, 31, 91872, 23, 26, 240, 18720, 33, 49, 4, 38, 37, 1457, 3, 799, 557568, 32, 1400, 47, 10, 20774, 1296, 9, 21, 92928, 8704, 29, 2162, 22, 1883700, 49588, 1078, 36, 44, 352, 546, 19, 523370496, 476, 24, 6000, 42, 30, 8, 16262400, 61600, 41, 24150, 1968, 7056, 7, 35, 16, 87, 20, 2730, 11616, 10912, 690, 150, 25, 6, 14, 1689120, 43, 3128, 27, 197472, 45, 15, 585, 21645, 39, 40, 2205, 17, 48, 136 }, 509730797)]
        public void NumFactoredBinaryTrees(int[] input, int expected)
        {
            var sut = new BinaryTreesWithFactors();
            var actual = sut.NumFactoredBinaryTrees(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
