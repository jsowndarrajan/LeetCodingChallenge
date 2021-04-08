using Shared.Interfaces;
using System.Collections.Generic;

namespace April.Problems
{
    public class LetterCombinationsOfAPhoneNumber : IProblem
    {
        public string Title => "Letter Combinations of a Phone Number";
        public string Url => "https://leetcode.com/explore/challenge/card/april-leetcoding-challenge-2021/594/week-2-april-8th-april-14th/3701/";

        private Dictionary<char, string> map => new Dictionary<char, string> {
            { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" },
            { '6', "mno" }, { '7', "pqrs"}, { '8', "tuv" }, { '9', "wxyz"},
        };

        public IList<string> LetterCombinations(string digits)
        {
            var output = new List<string>();
            CalculateCombinations(digits, 0, string.Empty, output);
            return output;
        }

        private void CalculateCombinations(string digits, int index, string previous, List<string> output)
        {
            if (digits.Length == 0) return;

            if (digits.Length == index)
            {
                output.Add(previous);
            }
            else
            {
                var possibleCharacters = map[digits[index]];
                foreach (var @char in possibleCharacters)
                {
                    CalculateCombinations(digits, index + 1, previous + @char, output);
                }
            }
        }
    }
}
