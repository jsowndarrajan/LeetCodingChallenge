using January.Problems;
using NUnit.Framework;

namespace January.Tests.Problems
{
    internal class BoatsToSavePeopleTests
    {
        private BoatsToSavePeople _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new BoatsToSavePeople();
        }

        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void AddTwoNumbers(int[] people, int limit, int expected)
        {
            var actual = _sut.NumRescueBoats(people, limit);
            Assert.AreEqual(expected, actual);
        }

        private static readonly object[] TestCaseSource =
        {
            new object[]
            {
                new[] {1, 2 },
                3,
                1
            },
            new object[]
            {
                new[] {1,1,1,2,2,2},
                3,
                3
            },
            new object[]
            {
                new[] {3,2,2,1},
                3,
                3
            },
            new object[]
            {
                new[] {3,5,3,4},
                5,
                4
            },
        };
    }
}
