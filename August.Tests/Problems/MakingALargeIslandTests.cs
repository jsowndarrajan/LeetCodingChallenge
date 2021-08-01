using August.Problems;
using NUnit.Framework;
using System.Collections.Generic;

namespace August.Tests.Problems
{
    public class MakingALargeIslandTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void LargestIsland(List<int[]> input, int expected)
        {
            var sut = new MakingALargeIsland();
            var actual = sut.LargestIsland(input.ToArray());
            Assert.AreEqual(expected, actual);
        }

        private static object[] TestCaseSource => new[]
        {
            new object[]
            {
                new List<int[]>
                {
                    new []{ 1, 0 },
                    new []{ 0, 1 },
                },
                3
            },
            new object[]
            {
                new List<int[]>
                {
                    new []{ 1, 1 },
                    new []{ 0, 1 },
                },
                4
            },
            new object[]
            {
                new List<int[]>
                {
                    new []{ 1, 1 },
                    new []{ 1, 1 },
                },
                4
            },
            new object[]
            {
                new List<int[]>
                {
                    new []{ 0, 1, 0 },
                    new []{ 1, 0, 1 },
                    new []{ 0, 1, 0 }
                },
                5
            }
        };
    }
}