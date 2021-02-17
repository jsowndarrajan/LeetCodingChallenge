using February.Problems;
using NUnit.Framework;

namespace February.Tests.Problems
{
    public class ContainerWithMostWaterTests
    {
        [TestCase(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [TestCase(new[] { 4, 3, 2, 1, 4 }, 16)]
        [TestCase(new[] { 1, 2, 1 }, 2)]
        [TestCase(new[] { 1, 1 }, 1)]
        public void MaxArea(int[] height, int expected)
        {
            var sut = new ContainerWithMostWater();
            var actual = sut.MaxArea(height);
            Assert.AreEqual(expected, actual);
        }
    }
}
