using March.Problems;
using NUnit.Framework;
using System.Collections.Generic;

namespace March.Tests.Problems
{
    public class RussianDollEnvelopesTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void MaxEnvelopes(List<int[]> envelopes, int expected)
        {
            var sut = new RussianDollEnvelopes();
            var actual = sut.MaxEnvelopes(envelopes.ToArray());
            Assert.AreEqual(expected, actual);
        }

        private static object[] TestCaseSource => new object[]
        {
            new object[]
            {
                new List<int[]> {new[] {5, 4}, new[] {6, 4}, new[] {6, 7}, new[] {2, 3}},
                3
            },
            new object[]
            {
                new List<int[]> {new[] {1, 1}, new[] {1, 1}, new[] {1, 1}, new[] {1, 1}},
                1
            },
            new object[]
            {
                new List<int[]> {new[] {30, 50}, new[] {12, 2}, new[] {3, 4}, new[] {12, 15}},
                3
            },
            new object[]
            {
                new List<int[]> {new[] {1, 3}, new[] {3, 5}, new[] {6, 7}, new[] {6, 8}, new[] {8, 4}, new[] {9, 5}},
                3
            },
            new object[]
            {
                new List<int[]> {new[] {2, 100}, new[] {3, 200}, new[] {4, 300}, new[] {5, 500}, new[] {5, 400}, new[] {5, 250}, new[] {6, 370}, new[] {6, 360}, new[] {7, 380}},
                5
            },
        };
    }
}
