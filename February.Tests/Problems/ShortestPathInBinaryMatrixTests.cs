using February.Problems;
using NUnit.Framework;
using System.Collections.Generic;

namespace February.Tests.Problems
{
    public class ShortestPathInBinaryMatrixTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void ShortestPathBinaryMatrix(List<int[]> input, int expected)
        {
            var sut = new ShortestPathInBinaryMatrix();
            var actual = sut.ShortestPathBinaryMatrix(input.ToArray());
            Assert.AreEqual(expected, actual);
        }

        public static object[] TestCaseSource => new object[]
        {
            new object[]
            {
                new List<int[]> {new []{0,1}, new[] {1, 0}},
                2
            },
            new object[]
            {
                new List<int[]> {new[] {0, 0, 0}, new[] {1, 1, 0}, new[] {1, 1, 0}},
                4
            },
            new object[]
            {
                new List<int[]> {new[] {0, 0, 0}, new[] {1, 1, 0}, new[] {1, 1, 1}},
                -1
            },
            new object[]
            {
                new List<int[]>
                {
                    new[] {0, 0, 1, 0, 0, 0, 0}, new[] {0, 1, 0, 0, 0, 0, 1}, new[] {0, 0, 1, 0, 1, 0, 0},
                    new[] {0, 0, 0, 1, 1, 1, 0}, new[] {1, 0, 0, 1, 1, 0, 0}, new[] {1, 1, 1, 1, 1, 0, 1},
                    new[] {0, 0, 1, 0, 0, 0, 0}
                },
                10
            }
        };
    }
}
