using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class NextPermutationTests
    {
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 1, 3, 2 }, new[] { 2, 1, 3 })]
        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 3, 2 })]
        [TestCase(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
        [TestCase(new[] { 1, 1, 5 }, new[] { 1, 5, 1 })]
        public void FindNextPermutation(int[] input, int[] expected)
        {
            var sut = new NextPermutation();
            sut.FindNextPermutation(input);
            Assert.AreEqual(expected, input);
        }
    }
}
