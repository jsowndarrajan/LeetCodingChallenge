using System.Collections.Generic;
using Shared.Interfaces;

namespace April.Problems
{
    public class RemoveAllAdjacentDuplicatesInString2 : IProblem
    {
        public string Title => "Remove All Adjacent Duplicates in String II";
        public string Url => "https://leetcode.com/explore/challenge/card/april-leetcoding-challenge-2021/595/week-3-april-15th-april-21st/3710/";

        public string RemoveDuplicates(string input, int k)
        {
            var charsStack = new Stack<char>();
            var countStack = new Stack<int>();

            for (var i = 0; i < input.Length; i++)
            {
                if (charsStack.Count > 0)
                {
                    var lastCharacter = charsStack.Peek();
                    var lastCharacterCount = countStack.Peek();

                    if (lastCharacter == input[i])
                    {
                        var newCount = lastCharacterCount + 1;
                        if (newCount == k)
                        {
                            RemoveCharacters(lastCharacterCount, charsStack, countStack);
                        }
                        else
                        {
                            AddToStack(charsStack, countStack, input[i], newCount);
                        }
                    }
                    else
                    {
                        AddToStack(charsStack, countStack, input[i], 1);
                    }
                }
                else
                {
                    AddToStack(charsStack, countStack, input[i], 1);
                }
            }
            return GenerateOutput(charsStack);
        }

        private static string GenerateOutput(Stack<char> stack)
        {
            var output = string.Empty;
            while (stack.Count > 0)
            {
                output = stack.Pop() + output;
            }
            return output;
        }

        private static void AddToStack(Stack<char> stack, Stack<int> countStack, char item, int count)
        {
            stack.Push(item);
            countStack.Push(count);
        }

        private static void RemoveCharacters(int lastCharacterCount, Stack<char> stack, Stack<int> count)
        {
            while (lastCharacterCount > 0)
            {
                stack.Pop();
                count.Pop();
                lastCharacterCount--;
            }
        }
    }
}
