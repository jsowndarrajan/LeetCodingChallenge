using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class SortTheMatrixDiagonallyTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void DiagonalSort(int[][] input, int[][] expected)
        {
            var sut = new SortTheMatrixDiagonally();
            var actual = sut.DiagonalSort(input);
            Assert.AreEqual(expected, actual);
        }

        private static readonly object[] TestCaseSource =
        {
            new object[]
            {
                new[] {new[] {3, 3, 1, 1}, new[] {2, 2, 1, 2}, new[] {1, 1, 1, 2}},
                new[] {new[] {1, 1, 1, 1}, new[] {1, 2, 2, 2}, new[] {1, 2, 3, 3}}
            }
        };

    }
}
