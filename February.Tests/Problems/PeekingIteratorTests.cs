using February.Problems;
using NUnit.Framework;
using System.Collections.Generic;

namespace February.Tests.Problems
{
    public class PeekingIteratorTests
    {
        [Test]
        public void Test1()
        {
            var input = new List<int> {1, 2, 3};
            var sut = new PeekingIterator(input.GetEnumerator());
            Assert.AreEqual(1, sut.Next());
            Assert.AreEqual(2, sut.Peek());
            Assert.AreEqual(2, sut.Next());
            Assert.True(sut.HasNext());
            Assert.AreEqual(3, sut.Next());
            Assert.False(sut.HasNext());
        }

        [Test]
        public void Test2()
        {
            var input = new List<int> { 1, 2, 3 };
            var iterator = input.GetEnumerator();
            iterator.MoveNext();
            var sut = new PeekingIterator1(iterator);
            Assert.AreEqual(1, sut.Next());
            Assert.AreEqual(2, sut.Peek());
            Assert.AreEqual(2, sut.Next());
            Assert.True(sut.HasNext());
            Assert.AreEqual(3, sut.Next());
            Assert.False(sut.HasNext());
        }
    }
}
