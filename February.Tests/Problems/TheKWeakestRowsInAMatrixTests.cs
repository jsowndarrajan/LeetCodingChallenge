using NUnit.Framework;
using System.Collections.Generic;
using February.Problems;

namespace February.Tests.Problems
{
    public class TheKWeakestRowsInAMatrixTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void KWeakestRows(List<int[]> input, int target, int[] expected)
        {
            var sut = new TheKWeakestRowsInAMatrix();
            var actual = sut.KWeakestRows(input.ToArray(), target);
            Assert.AreEqual(expected, actual);
        }

        public static object[] TestCaseSource => new object[]
        {
            new object[]
            {
                new List<int[]>
                {
                    new []{1,1,0,0,0},
                    new []{1,1,1,1,0},
                    new []{1,0,0,0,0},
                    new []{1,1,0,0,0},
                    new []{1,1,1,1,1}
                },
                3,
                new[] {2, 0, 3}
            },
            new object[]
            {
                new List<int[]>
                {
                    new []{1,0,0,0},
                    new []{1,1,1,1},
                    new []{1,0,0,0},
                    new []{1,0,0,0}
                },
                2,
                new[] {0, 2}
            }
        };
    }
}
