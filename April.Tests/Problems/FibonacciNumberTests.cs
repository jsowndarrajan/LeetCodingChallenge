using April.Problems;
using NUnit.Framework;

namespace April.Tests.Problems
{
    public class FibonacciNumberTests
    {
        [TestCase(1, 1)]
        [TestCase(5, 5)]
        [TestCase(10, 55)]
        [TestCase(30, 832040)]
        public void Fib(int n, int expected)
        {
            var sut = new FibonacciNumber();
            var actual = sut.Fib(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
