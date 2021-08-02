using August.Problems;
using NUnit.Framework;

namespace August.Tests.Problems
{
    public class TwoSumTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void LargestIsland(int[] input, int target, int[] expected)
        {
            var sut = new TwoSum();
            var actual = sut.Calculate(input, target);
            Assert.AreEqual(expected, actual);
        }

        private static object[] TestCaseSource => new[]
        {
            new object[]
            {
                new[] { 2, 7, 11, 15 }, 
                9,
                new[] { 0, 1 }
            },
            new object[]
            {
                new[] { 3, 2, 4 },
                6,
                new[] { 1, 2 }
            },
            new object[]
            {
                new[] { 3, 3 },
                6,
                new[] { 0, 1 }
            }
        };
    }
}
