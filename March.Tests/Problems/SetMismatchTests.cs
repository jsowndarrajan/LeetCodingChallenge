using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class SetMismatchTests
    {
        [TestCase(new[] {1,2,2,4}, new[] {2,3})]
        [TestCase(new[] {1,1}, new[] {1,2})]
        [TestCase(new[] {2,2}, new[] {2,1})]
        public void FindErrorNums(int[] nums, int[] expected)
        {
            var sut = new SetMismatch();
            var actual = sut.FindErrorNums(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
