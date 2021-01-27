using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class PathWithMinimumEffortTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void MinimumEffortPath(int[][] heights, int expected)
        {
            var sut = new PathWithMinimumEffort();
            var actual = sut.MinimumEffortPath(heights);
            Assert.AreEqual(expected, actual);
        }

        private static readonly object[] TestCaseSource =
        {
            new object[]
            {
                new[] { new[] {1,2,2}, new [] {3,8,2}, new [] {5,3,5} },
                2
            },
            new object[]
            {
                new[] { new[] {1,2,3}, new [] {3,8,4}, new [] {5,3,5} },
                1
            },
            new object[]
            {
                new[] { new[] { 1, 2, 1, 1, 1 }, new [] { 1, 2, 1, 2, 1 }, new [] { 1, 2, 1, 2, 1 }, new [] { 1, 2, 1, 2, 1 }, new [] { 1, 1, 1, 2, 1 } },
                0
            }
        };
    }
}
