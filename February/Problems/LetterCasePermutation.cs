using System;
using Shared.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace February.Problems
{
    public class LetterCasePermutation : IProblem
    {
        private const int CharacterOffset = 32;
        public string Title => "Letter Case Permutation";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/586/week-3-february-15th-february-21st/3642/";

        public string Execute(string input)
        {
            try
            {
                var result = ComputeLetterCasePermutation(input);
                return JsonConvert.SerializeObject(result);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IList<string> ComputeLetterCasePermutation(string input)
        {
            var output = new List<string>();
            Permute(input.ToCharArray(), 0, output);
            return output.ToList();
        }

        private static void Permute(char[] input, int start, List<string> output)
        {
            if (start == input.Length)
            {
                output.Add(new string(input));
                return;
            }

            if (char.IsNumber(input[start]))
            {
                Permute(input, start + 1, output);
                return;
            }

            Permute(input, start + 1, output);

            var negativeOffset = char.IsLower(input[start])? -1 : 1;
            input[start] += (char)(CharacterOffset * negativeOffset);
            Permute(input, start + 1, output);
            input[start] -= (char)(CharacterOffset * negativeOffset);
        }
    }
}
