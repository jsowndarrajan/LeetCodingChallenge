using February.Problems;
using NUnit.Framework;

namespace February.Tests.Problems
{
    public class ValidParenthesesTests
    {
        [TestCase("lee(t(c)o)de)", "lee(t(c)o)de")]
        [TestCase(")((c)d()(l", "(c)d()l")]
        [TestCase("a)b(c)d", "ab(c)d")]
        [TestCase("(a(b(c)d)", "a(b(c)d)")]
        [TestCase("))((", "")]
        public void MinRemoveToMakeValid(string input, string expected)
        {
            var sut = new ValidParentheses();
            var actual = sut.MinRemoveToMakeValid(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
