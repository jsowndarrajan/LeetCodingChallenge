using April.Problems;
using NUnit.Framework;

namespace April.Tests.Problems
{
    public class BeautifulArrangement2Tests
    {
        [TestCase(3, 1, new[] { 1, 2, 3 })]
        [TestCase(3, 2, new[] { 1, 3, 2 })]
        [TestCase(4, 2, new[] { 1, 3, 2, 4 })]
        [TestCase(4, 3, new[] { 1, 4, 2, 3 })]
        [TestCase(5, 2, new[] { 1, 3, 2, 4, 5 })]
        public void ConstructArray(int n, int k, int[] expected)
        {
            var sut = new BeautifulArrangement2();
            var actual = sut.ConstructArray(n, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
