using April.Problems;
using NUnit.Framework;

namespace April.Tests.Problems
{
    public class DetermineIfStringHalvesAreAlikeTests
    {
        [TestCase("book", true)]
        [TestCase("textbook", false)]
        [TestCase("MerryChristmas", false)]
        [TestCase("AbCdEfGh", true)]
        public void HalvesAreAlike(string input, bool expected)
        {
            var sut = new DetermineIfStringHalvesAreAlike();
            var actual = sut.HalvesAreAlike(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
