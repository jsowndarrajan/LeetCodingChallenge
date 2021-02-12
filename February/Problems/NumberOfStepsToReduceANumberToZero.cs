using System;
using Shared.Helpers;
using Shared.Interfaces;

namespace February.Problems
{
    public class NumberOfStepsToReduceANumberToZero : IProblem
    {
        public string Title => "Number of Steps to Reduce a Number to Zero";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/585/week-2-february-8th-february-14th/3637/";

        public string NumberOfSteps(string input)
        {
            try
            {
                if(int.TryParse(input, out int num))
                {
                   var result = NumberOfSteps(num);
                   return result.ToString();
                }

                return Messages.InvalidInput;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }   
        }

        public int NumberOfSteps(int num)
        {
            if(num < 0) throw new ArgumentException(Messages.InvalidInput);

            var steps = 0;
            while (num > 0)
            {
                num = (num % 2 > 0) ? num - 1 : num / 2;
                steps++;
            }
            return steps;
        }
    }
}
