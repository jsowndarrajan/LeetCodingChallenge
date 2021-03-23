using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class ThreeSumMultiplicityTests
    {
        [TestCase(new[] { 0, 2, 0 }, 2, 1)]
        [TestCase(new[] { 1, 0, 1, 0, 2, 1, 2 }, 1, 3)]
        [TestCase(new[] { 1, 1, 2, 2, 2, 2 }, 5, 12)]
        [TestCase(new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 }, 8, 20)]
        public void Calculate(int[] arr, int target, int expected)
        {
            var sut = new ThreeSumMultiplicity();
            var actual = sut.Calculate(arr, target);
            Assert.AreEqual(expected, actual);
        }
    }
}
