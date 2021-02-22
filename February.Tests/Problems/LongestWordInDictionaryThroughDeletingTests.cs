using February.Problems;
using NUnit.Framework;
using System.Collections.Generic;

namespace February.Tests.Problems
{
    public class LongestWordInDictionaryThroughDeletingTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void FindLongestWord(string input, IList<string> list, string expected)
        {
            var sut = new LongestWordInDictionaryThroughDeleting();
            var actual = sut.FindLongestWord(input, list);
            Assert.AreEqual(expected, actual);
        }

        private static object[] TestCaseSource() => new object[]
        {
            new object[]
            {
                "abpcplea", 
                new List<string> { "ale", "apple", "monkey", "plea" },
                "apple"
            },
            new object[]
            {
                "abpcplea",
                new List<string> { "a", "b", "c" },
                "a"
            },
            new object[]
            {
                "aewfafwafjlwajflwajflwafj",
                new List<string> { "apple","ewaf","awefawfwaf","awef","awefe","ewafeffewafewf" },
                "ewaf"
            },
            new object[]
            {
                "aaa",
                new List<string> { "aaa","aa","a" },
                "aaa"
            }
        };
}
}
