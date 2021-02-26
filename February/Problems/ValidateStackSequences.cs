using System;
using System.Collections.Generic;
using Shared.Helpers;
using Shared.Interfaces;

namespace February.Problems
{
    public class ValidateStackSequences : IProblem
    {
        public string Title => "Validate Stack Sequences";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/587/week-4-february-22nd-february-28th/3653/";

        public string Validate(string pushed, string popped)
        {
            try
            {
                var input1 = DataConverter.ConvertStringToIntArray(pushed);
                var input2 = DataConverter.ConvertStringToIntArray(popped);
                var result = Validate(input1, input2);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool Validate(int[] pushed, int[] popped)
        {
            var stack = new Stack<int>();

            var popIndex = 0;
            foreach (var item in pushed)
            {
                stack.Push(item);

                while (stack.Count > 0 && stack.Peek() == popped[popIndex])
                {
                    stack.Pop();
                    popIndex++;
                }
            }

            return stack.Count == 0;
        }
    }
}
