using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class MyHashMapTests
    {
        [Test]
        public void GetTest()
        {
            var sut = new MyHashMap();
           sut.Put(2, 20);

            var invalidKeyResult = sut.Get(1);
            Assert.AreEqual(-1, invalidKeyResult);

            var validKeyResult = sut.Get(2);
            Assert.AreEqual(20, validKeyResult);
        }

        [Test]
        public void PutTest()
        {
            var sut = new MyHashMap();
            
            sut.Put(2, 20);
            Assert.AreEqual(20, sut.Get(2));

            sut.Put(2, 10);
            Assert.AreEqual(10, sut.Get(2));
        }

        [Test]
        public void RemoveTest()
        {
            var sut = new MyHashMap();

            Assert.DoesNotThrow(() => sut.Remove(2));

            sut.Put(2, 10);
            Assert.AreEqual(10, sut.Get(2));
            sut.Remove(2);
            Assert.AreEqual(-1, sut.Get(2));
        }
    }
}
