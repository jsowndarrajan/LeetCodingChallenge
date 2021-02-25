using February.Problems;
using NUnit.Framework;

namespace February.Tests.Problems
{
    public class ShortestUnsortedContinuousSubArrayTests
    {
        [TestCase(new[] { 2, 6, 4, 8, 10, 9, 15 }, 5)]
        [TestCase(new[] { 1, 2, 3, 4 }, 0)]
        [TestCase(new[] { 5, 4, 3, 2, 1 }, 5)]
        [TestCase(new[] { 1 }, 0)]
        [TestCase(new[] { 2, 1 }, 2)]
        [TestCase(new[] { 1, 3, 2, 2, 2 }, 4)]
        [TestCase(new[] { 2, 3, 3, 2, 4 }, 3)]
        public void FindUnsortedSubArray(int[] input, int expected)
        {
            var sut = new ShortestUnsortedContinuousSubArray();
            var actual = sut.FindUnsortedSubArray(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
