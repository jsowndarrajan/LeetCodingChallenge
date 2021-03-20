using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class UndergroundSystemTests
    {
        [Test]
        public void GetAverageTime1()
        {
            var sut = new UndergroundSystem();
            sut.CheckIn(45, "Leyton", 3);
            sut.CheckIn(32, "Paradise", 8);
            sut.CheckIn(27, "Leyton", 10);
            sut.CheckOut(45, "Waterloo", 15);
            sut.CheckOut(27, "Waterloo", 20);
            sut.CheckOut(32, "Cambridge", 22);

            var actual = sut.GetAverageTime("Paradise", "Cambridge");
            Assert.AreEqual(14d, actual);

            actual = sut.GetAverageTime("Leyton", "Waterloo");
            Assert.AreEqual(11d, actual);

            sut.CheckIn(10, "Leyton", 24);
            actual = sut.GetAverageTime("Leyton", "Waterloo");
            Assert.AreEqual(11d, actual);

            sut.CheckOut(10, "Waterloo", 38);
            actual = sut.GetAverageTime("Leyton", "Waterloo");
            Assert.AreEqual(12d, actual);
        }

        [Test]
        public void GetAverageTime2()
        {
            var sut = new UndergroundSystem();
            sut.CheckIn(10, "Leyton", 3);
            sut.CheckOut(10, "Paradise", 8);

            var actual = sut.GetAverageTime("Leyton", "Paradise");
            Assert.AreEqual(5d, actual);

            sut.CheckIn(5, "Leyton", 10);
            sut.CheckOut(5, "Paradise", 16);
            actual = sut.GetAverageTime("Leyton", "Paradise");
            Assert.AreEqual(5.5d, actual);

            sut.CheckIn(2, "Leyton", 21);
            sut.CheckOut(2, "Paradise", 30);
            actual = sut.GetAverageTime("Leyton", "Paradise");
            Assert.AreEqual(6.666666666666667d, actual);
        }
    }
}
