using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.Interfaces;

namespace April.Problems
{
    public class FibonacciNumber : IProblem
    {
        public string Title => "Fibonacci Number";
        public string Url => "https://leetcode.com/explore/challenge/card/april-leetcoding-challenge-2021/595/week-3-april-15th-april-21st/3709/";

        public int Fib(int n)
        {
            if (n < 2) return n;

            var a = 0;
            var b = 1;

            for (var i = 2; i <= n; i++)
            {
                var temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }
    }
}
