using Shared.Helpers;
using Shared.Interfaces;
using System;

namespace February.Problems
{
    public class ArithmeticSlices: IProblem
    {
        public string Title => "Arithmetic Slices";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/586/week-3-february-15th-february-21st/3644/";

        public string NumberOfArithmeticSlices(string input)
        {
            try
            {
                var numbers = DataConverter.ConvertStringToIntArray(input);
                var result = NumberOfArithmeticSlices(numbers);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int NumberOfArithmeticSlices(int[] input)
        {
            if (input.Length <= 2) return 0;

            var result = 0;
            var map = new int[input.Length];
            var previousDifference = input[0] - input[1];
            for (var i = 2; i < input.Length; i++)
            {
                var currentDifference = input[i-1] - input[i];
                if (previousDifference == currentDifference)
                {
                    map[i] = map[i - 1] + 1;
                }
                previousDifference = currentDifference;
                result += map[i];
            }
            return result;
        }
    }
}
