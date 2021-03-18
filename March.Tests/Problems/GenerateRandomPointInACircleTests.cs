using March.Problems;
using NUnit.Framework;
using System;

namespace March.Tests.Problems
{
    public class GenerateRandomPointInACircleTests
    {
        [TestCase(1, 0, 0, 100)]
        [TestCase(10, 5, -7.5, 100)]
        public void RandPoint(double radius, double xCenter, double yCenter, int loopCount)
        {
            var sut = new GenerateRandomPointInACircle(radius, xCenter, yCenter);

            while (loopCount > 0)
            {
                var actual = sut.RandPoint();
                Assert.True(Math.Pow((actual[0] - xCenter), 2) + Math.Pow((actual[1] - yCenter), 2) <= Math.Pow(radius, 2));
                loopCount--;
            }
        }
    }
}
