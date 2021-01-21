using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class FindTheMostCompetitiveSubsequenceTests
    {
        [TestCase(new[] {5,1,5,4,2}, 2, new[] {1,2})]
        [TestCase(new[] { 2, 4, 3, 3, 5, 4, 9, 6 }, 4, new[] {2,3,3,4})]
        [TestCase(new[] { 71, 18, 52, 29, 55, 73, 24, 42, 66, 8, 80, 2 }, 3, new[] {8, 80, 2})]
        [TestCase(new[] { 84, 10, 71, 23, 66, 61, 62, 64, 34, 41, 80, 25, 91, 43, 4, 75, 65, 13, 37, 41, 46, 90, 55, 8, 85, 61, 95, 71 }, 24, new[] {10,23,61,62,34, 41, 80, 25, 91, 43, 4, 75, 65, 13, 37, 41, 46, 90, 55, 8, 85, 61, 95, 71 })]
        public void MostCompetitive(int[] nums, int k, int[] expected)
        {
            var sut = new FindTheMostCompetitiveSubsequence();
            var actual = sut.MostCompetitive(nums, k);
            Assert.AreEqual(expected, actual);
        }
    }
}