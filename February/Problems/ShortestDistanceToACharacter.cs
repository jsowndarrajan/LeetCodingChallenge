using Newtonsoft.Json;
using Shared.Interfaces;
using System;
using Shared.Helpers;

namespace February.Problems
{
    public class ShortestDistanceToACharacter : IProblem
    {
        public string Title => "Shortest Distance to a Character";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/584/week-1-february-1st-february-7th/3631/";

        public string ShortestToCharacter(string input, string target)
        {
            try
            {
                if (target?.Length == 0) return Messages.InvalidInput;

                var result = ShortestToChar(input, target[0]);
                return JsonConvert.SerializeObject(result);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int[] ShortestToChar(string input, char character)
        {
            var output = new int[input.Length];

            var indexPosition = -100000;
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == character)
                {
                    indexPosition = i;
                }
                output[i] = i - indexPosition;
            }

            indexPosition = 100000;
            for (var i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == character)
                {
                    indexPosition = i;
                }
                output[i] = Math.Min(output[i], indexPosition - i);
            }

            return output;
        }
    }
}
