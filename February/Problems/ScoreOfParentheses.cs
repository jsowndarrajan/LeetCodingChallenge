using Shared.Interfaces;
using System;
using System.Collections.Generic;

namespace February.Problems
{
    public class ScoreOfParentheses : IProblem
    {
        public string Title => "Score of Parentheses";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/587/week-4-february-22nd-february-28th/3651/";

        public int Compute(string input)
        {
            var output = 0;
            var stack = new Stack<int>();
            foreach (var @char in input)
            {
                if (@char == '(')
                {
                    stack.Push(output);
                    output = 0;
                }
                else
                {
                    output = stack.Pop() + Math.Max(2 * output, 1);
                }
            }
            return output;
        }
    }
}
