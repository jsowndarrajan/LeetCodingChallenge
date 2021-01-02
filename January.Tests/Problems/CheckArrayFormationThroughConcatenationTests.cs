using January.Problems;
using NUnit.Framework;
using System.Collections.Generic;

namespace January.Tests.Problems
{
    public class CheckArrayFormationThroughConcatenationTests
    {
        private CheckArrayFormationThroughConcatenation _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new CheckArrayFormationThroughConcatenation();
        }

        [Test, TestCaseSource(nameof(_testCaseSource))]
        public void CanFormArray(int[] targetArray, int[][] pieces, bool expected)
        {
            var actual = _sut.CanFormArray(targetArray, pieces);
            Assert.AreEqual(expected, actual);
        }

        private static readonly object[] _testCaseSource =
        {
            new object[]
            {
                new[] {85},
                new List<int[]>{ new[] {85}}.ToArray(),
                true
            },
            new object[]
            {
                new[] {15,85},
                new List<int[]>{ new[] {85}, new[] {15}}.ToArray(),
                true
            },
            new object[]
            {
                new[] {49,18,16},
                new List<int[]>{ new[] {16,18,49}}.ToArray(),
                false
            },
            new object[]
            {
                new[] {91,4,64,78},
                new List<int[]>{ new[] {78}, new[] {4,64}, new[] {91}}.ToArray(),
                true
            },
            new object[]
            {
                new[] {1,3,5,7},
                new List<int[]>{ new[] {2,4,6,8}}.ToArray(),
                false
            }
        };
    }
}
