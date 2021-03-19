using NUnit.Framework;
using System.Collections.Generic;
using March.Problems;

namespace March.Tests.Problems
{
    public class KeysAndRoomsTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void CanVisitAllRooms(List<List<int>> rooms, bool expected)
        {
            var sut = new KeysAndRooms();
            var actual = sut.CanVisitAllRooms(rooms);
            Assert.AreEqual(expected, actual);
        }

        private static object[] TestCaseSource => new object[]
        {
            new object[]
            {
                new List<List<int>>
                {
                    new List<int> { 1 },
                    new List<int> { 2 },
                    new List<int> { 3 },
                    new List<int> ()
                },
                true
            },
            new object[]
            {
                new List<List<int>>
                {
                    new List<int> { 1, 3 },
                    new List<int> { 3, 0, 1},
                    new List<int> { 2 },
                    new List<int> { 0 }
                },
                false
            }
        };
    }
}
