using Shared.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace February.Problems
{
    public class ValidParentheses: IProblem
    {
        public string Title => "Minimum Remove to Make Valid Parentheses";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/586/week-3-february-15th-february-21st/3645/";

        public string MinRemoveToMakeValid(string s)
        {
            var input = s.ToCharArray();
            var stack = new Stack<int>();

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }

                if (input[i] == ')')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        input[i] = '\0';
                    }
                }
            }

            while (stack.Count != 0)
            {
                input[stack.Pop()] = '\0';
            }

            var output = new StringBuilder();
            foreach (var @char in input)
            {
                if(@char == '\0') continue;
                output.Append(@char);
            }
            return output.ToString();
        }
    }
}
