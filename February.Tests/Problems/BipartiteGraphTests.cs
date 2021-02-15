using February.Problems;
using NUnit.Framework;
using System.Collections.Generic;

namespace February.Tests.Problems
{
    public class BipartiteGraphTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void IsBipartite(List<int[]> input, bool expected)
        {
            var sut = new BipartiteGraph();
            var actual = sut.IsBipartite(input.ToArray());
            Assert.AreEqual(expected, actual);
        }

        public static object[] TestCaseSource => new object[]
        {
            new object[]
            {
                new List<int[]>{ new[]{1,3}, new[] {0,2}, new [] {1,3}, new [] {0,2} },
                true
            },
            new object[]
            {
                new List<int[]>{ new[]{1,2,3}, new[] {0,2}, new [] {0,1,3}, new [] {0,2} },
                false
            },
            new object[]
            {
                new List<int[]>{ new[]{1}, new[] {0,3}, new [] {3}, new [] {1,2} },
                true
            },
            new object[]
            {
                new List<int[]>{ new[]{4,1}, new[] {0,2}, new [] {1,3}, new [] {2,4}, new [] {3,0} },
                false
            },
            new object[]
            {
                new List<int[]>{ new[]{3}, new[] {2,4}, new [] {1}, new [] {0,4}, new [] {1,3} },
                true
            }
        };
    }
}
