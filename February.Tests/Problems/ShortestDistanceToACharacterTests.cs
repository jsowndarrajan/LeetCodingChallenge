using February.Problems;
using NUnit.Framework;

namespace February.Tests.Problems
{
    public class ShortestDistanceToACharacterTests
    {
        [TestCase("loveleetcode", 'e', new[] { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 })]
        [TestCase("aaab", 'b', new[] { 3, 2, 1, 0 })]
        public void ShortestToChar(string input, char character, int[] expected)
        {
            var sut = new ShortestDistanceToACharacter();
            var actual = sut.ShortestToChar(input, character);
            Assert.AreEqual(expected, actual);
        }
    }
}
