using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class StampingTheSequenceTests
    {
        [TestCase("abc", "ababc", new[] {0,2} )]
        [TestCase("abca", "aabcaca", new[] {3,0,1} )]
        [TestCase("h", "hhhhh", new[] {4,3,2,1,0} )]
        [TestCase("oz", "ooozz", new[] {3,0,1,2} )]
        [TestCase("aye", "eyeye", new int[0] )]
        [TestCase("lemk", "lleme", new int[0] )]
        [TestCase("cab", "cabbb", new[] { 2, 1, 0})]
        public void MovesToStamp(string stamp, string target, int[] expected)
        {
            var sut = new StampingTheSequence();
            var actual = sut.MovesToStamp(stamp, target);
            Assert.AreEqual(expected, actual);
        }
    }
}
