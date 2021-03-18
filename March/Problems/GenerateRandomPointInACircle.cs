using Shared.Interfaces;
using System;

namespace March.Problems
{
    public class GenerateRandomPointInACircle : IProblem
    {
        private double _x;
        private double _y;
        private double _radius;
        private readonly Random _random = new Random();

        public string Title => "Generate Random Point in a Circle";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/590/week-3-march-15th-march-21st/3675/";

        public GenerateRandomPointInACircle()
        {
        }

        public GenerateRandomPointInACircle(double radius, double xCenter, double yCenter)
        {
            Init(radius, xCenter, yCenter);
        }

        public void Init(double radius, double xCenter, double yCenter)
        {
            _x = xCenter;
            _y = yCenter;
            _radius = radius;
        }

        public double[] RandPoint()
        {
            while (true)
            {
                var a = GetRandomPoint(_x, _radius);
                var b = GetRandomPoint(_y, _radius);

                if (LiesInsideCircle(a, b)) return new[] { a, b };
            }
        }

        private bool LiesInsideCircle(double a, double b)
        {
            return Math.Pow((a - _x), 2) + Math.Pow((b - _y), 2) <= Math.Pow(_radius, 2);
        }

        private double GetRandomPoint(double center, double radius)
        {
            return (center - radius) + (_random.NextDouble() * 2 * radius);
        }
    }
}
