using Shared.Interfaces;
using System.Collections.Generic;

namespace January.Problems
{
    public class ValidParentheses : IProblem
    {
        public string Title => "Valid Parentheses";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/581/week-3-january-15th-january-21st/3610/";
        public bool IsValid(string input)
        {
            var stack = new Stack<char>();

            foreach (var @char in input)
            {
                if (@char == '(' || @char == '[' || @char == '{')
                {
                    stack.Push(@char);
                }
                else
                {
                    if (stack.Count == 0) return false;

                    var previousChar = stack.Peek();
                    if ((@char == ')' && previousChar == '(')
                        ||
                        (@char == ']' && previousChar == '[')
                        ||
                        (@char == '}' && previousChar == '{'))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
