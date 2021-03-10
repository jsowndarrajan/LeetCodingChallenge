using Shared.Helpers;
using Shared.Interfaces;
using System.Collections.Generic;

namespace March.Problems
{
    public class IntegerToRoman : IProblem
    {
        public string Title => "Integer to Roman";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/589/week-2-march-8th-march-14th/3667/";

        private Dictionary<int, string> IntRomanMap => new Dictionary<int, string>
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

        public string IntToRoman(string input)
        {
            if (int.TryParse(input, out var num))
            {
                return IntToRoman(num);
            }
            return Messages.InvalidInput;
        }

        public string IntToRoman(int num)
        {
            var output = string.Empty;
            foreach (var kvp in IntRomanMap)
            {
                var numberOfDigits = num / kvp.Key;
                if (numberOfDigits <= 0) continue;

                num %= kvp.Key;
                do
                {
                    output += kvp.Value;
                    numberOfDigits--;
                } while (numberOfDigits > 0);
            }
            return output;
        }
    }
}
