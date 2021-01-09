using January.Problems;
using NUnit.Framework;
using System.Collections.Generic;

namespace January.Tests.Problems
{
    public class WordLadderTests
    {
        private WordLadder _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new WordLadder();
        }

        [Test, TestCaseSource(nameof(_testCaseSource))]
        public void DeleteDuplicatesTest(string beginWord, string endWord, IList<string> wordList, int expected)
        {
            var actual = _sut.LadderLength(beginWord, endWord, wordList);
            Assert.AreEqual(expected, actual);
        }

        private static readonly object[] _testCaseSource =
        {
            new object[]
            {
                "hit", "cog", new List<string> {"hot", "dot", "dog", "lot", "log", "cog"}, 5
            },
            new object[]
            {
                "hit", "cog", new List<string> {"hot", "dot", "dog", "lot", "log"}, 0
            },
            new object[]
            {
                "hit", "cog", new List<string> {"abc", "cog"}, 0
            },
            new object[]
            {
                "", "", new List<string>(), 0 
            }
        };
    }

}
