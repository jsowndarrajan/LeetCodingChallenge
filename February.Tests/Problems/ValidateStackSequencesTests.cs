using February.Problems;
using NUnit.Framework;

namespace February.Tests.Problems
{
    public class ValidateStackSequencesTests
    {
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 4, 5, 3, 2, 1 }, true)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 4, 3, 5, 1, 2 }, false)]
        public void Validate(int[] pushed, int[] popped, bool expected)
        {
            var sut = new ValidateStackSequences();
            var actual = sut.Validate(pushed, popped);
            Assert.AreEqual(expected, actual);
        }
    }
}
