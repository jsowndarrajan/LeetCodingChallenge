using February.Problems;
using NUnit.Framework;

namespace February.Tests.Problems
{
    public class FreqStackTests
    {
        [Test]
        public void Validate1()
        {
            var sut = new FreqStack();
            sut.Push(5);
            sut.Push(7);
            sut.Push(5);
            sut.Push(7);
            sut.Push(4);
            sut.Push(5);

            Assert.AreEqual(5, sut.Pop());
            Assert.AreEqual(7, sut.Pop());
            Assert.AreEqual(5, sut.Pop());
            Assert.AreEqual(4, sut.Pop());
            Assert.AreEqual(7, sut.Pop());
            Assert.AreEqual(5, sut.Pop());
        }

        [Test]
        public void Validate2()
        {
            var sut = new FreqStack();
            sut.Push(4);
            sut.Push(0);
            sut.Push(9);
            sut.Push(3);
            sut.Push(4);
            sut.Push(2);
            Assert.AreEqual(4, sut.Pop());
            sut.Push(6);
            Assert.AreEqual(6, sut.Pop());
            sut.Push(1);
            Assert.AreEqual(1, sut.Pop());
            sut.Push(1);
            Assert.AreEqual(1, sut.Pop());
            sut.Push(4);
            Assert.AreEqual(4, sut.Pop());
            Assert.AreEqual(2, sut.Pop());
            Assert.AreEqual(3, sut.Pop());
            Assert.AreEqual(9, sut.Pop());
            Assert.AreEqual(0, sut.Pop());
            Assert.AreEqual(4, sut.Pop());
        }
    }
}
