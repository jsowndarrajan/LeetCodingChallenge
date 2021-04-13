using April.Problems;
using NUnit.Framework;
using System.Collections.Generic;

namespace April.Tests.Problems
{
    public class NestedIteratorTests
    {
        [Test]
        public void Test1()
        {
            var expected = new[] { 1, 2, 3, 4 };
            var index = 0;
            var integers = new List<NestedInteger>
            {
                new NestedInteger(1),
                new NestedInteger(new List<NestedInteger>
                {
                    new NestedInteger(2),
                    new NestedInteger(3),
                }),
                new NestedInteger(4)
            };
            var sut = new NestedIterator(integers);
            while (sut.HasNext())
            {
                Assert.AreEqual(expected[index++], sut.Next());
            }
        }

        [Test]
        public void Test2()
        {
            var integers = new List<NestedInteger>
            {
                new NestedInteger(new List<NestedInteger>())
            };
            var sut = new NestedIterator(integers);
            Assert.IsFalse(sut.HasNext());
        }
    }
}
