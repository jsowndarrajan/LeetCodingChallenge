using February.Problems;
using NUnit.Framework;
using System.Collections.Generic;

namespace February.Tests.Problems
{
    public class SearchA2DMatrix2Tests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void SearchMatrix(List<int[]> matrix, int target, bool expected)
        {
            var sut = new SearchA2DMatrix2();
            var actual = sut.SearchMatrix(matrix.ToArray(), target);
            Assert.AreEqual(expected, actual);
        }

        public static object[] TestCaseSource => new object[]
        {
            new object[]
            {
                new List<int[]>
                {
                    new[] {1, 4, 7, 11, 15},
                    new[] {2, 5, 8, 12, 19},
                    new[] {3, 6, 9, 16, 22},
                    new[] {10, 13, 14, 17, 24},
                    new[] {18, 21, 23, 26, 30}
                },
                5,
                true
            },
            new object[]
            {
                new List<int[]>
                {
                    new[] {1, 3, 7, 11, 15},
                    new[] {2, 4, 8, 12, 19},
                    new[] {3, 5, 9, 16, 22},
                    new[] {10, 13, 14, 17, 24},
                    new[] {18, 21, 23, 26, 30}
                },
                17,
                true
            },
            new object[]
            {
                new List<int[]>
                {
                    new[] {1, 3, 7, 11, 15},
                    new[] {2, 4, 8, 12, 19},
                    new[] {3, 5, 9, 16, 22},
                    new[] {10, 13, 14, 17, 24},
                    new[] {18, 21, 23, 26, 30}
                },
                40,
                false
            },
            new object[]
            {
                new List<int[]>
                {
                    new[] {1, 2, 3, 4, 5},
                    new[] {6, 7, 8, 9, 10},
                    new[] {11, 12, 13, 14, 15},
                    new[] {16, 17, 18, 19, 20},
                    new[] {21, 22, 23, 24, 25}
                },
                15,
                true
            }
        };
    }
}
