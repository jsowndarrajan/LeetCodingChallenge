using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    public class CheckIfAll1SAreAtLeastLengthKPlacesAwayTests
    {
        [TestCase(new[] { 1, 1, 1, 1 }, 0, true)]
        [TestCase(new[] { 0, 1, 0, 1 }, 0, true)]
        [TestCase(new[] { 1, 0, 0, 1, 0, 1 }, 2, false)]
        [TestCase(new[] { 1, 0, 0, 0, 1, 0, 0, 1 }, 2, true)]
        public void KLengthApart(int[] nums, int k, bool expected)
        {
            var sut = new CheckIfAll1SAreAtLeastLengthKPlacesAway();
            var actual = sut.KLengthApart(nums, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
