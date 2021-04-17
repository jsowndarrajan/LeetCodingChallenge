using April.Problems;
using NUnit.Framework;

namespace April.Tests.Problems
{
    public class RemoveAllAdjacentDuplicatesInString2Tests
    {
        [TestCase("abcd", 2, "abcd")]
        [TestCase("deeedbbcccbdaa", 3, "aa")]
        public void RemoveDuplicates(string input, int k, string expected)
        {
            var sut = new RemoveAllAdjacentDuplicatesInString2();
            var actual = sut.RemoveDuplicates(input, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
