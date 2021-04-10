using System.Collections.Generic;
using April.Problems;
using NUnit.Framework;

namespace April.Tests.Problems
{
    public class LongestIncreasingPathInAMatrixTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void LongestIncreasingPath(List<int[]> matrix, int expected)
        {
            var sut = new LongestIncreasingPathInAMatrix();
            var actual = sut.LongestIncreasingPath(matrix.ToArray());
            Assert.AreEqual(expected, actual);
        }

        private static object[] TestCaseSource => new[]
        {
            new object[]
            {
                new List<int[]>
                {
                    new []{ 9, 9, 4},
                    new []{ 6, 6, 8},
                    new []{ 2, 1, 1},
                },
                4
            },
            new object[]
            {
                new List<int[]>
                {
                    new []{ 3, 4, 5},
                    new []{ 3, 2, 6},
                    new []{ 2, 2, 1}
                },
                4
            },
            new object[]
            {
                new List<int[]>
                {
                    new []{ 1 }
                },
                1
            }
        };
    }
}