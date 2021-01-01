using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace January.Helpers
{
    public class DataConverter
    {
        private const string InvalidInput = "Invalid Input";

        public static int[] ConvertStringToIntArray(string input)
        {
            var match = Regex.Match(input.Trim(), @"\[([0-9,\s]*)\]");
            if (!match.Success) throw new ArgumentException(InvalidInput);

            try
            {
                if (match.Groups.Count == 2 &&
                   string.IsNullOrWhiteSpace(match.Groups[1].Value))
                    return new int[] { };

                return match.Groups[1].Value
                    .Split(',')
                    .Select(x => int.Parse(x.Trim()))
                    .ToArray();
            }
            catch (Exception)
            {
                throw new ArgumentException(InvalidInput);
            }
        }

        public static int[][] ConvertStringToNestedArray(string input)
        {
            var matches = Regex.Matches(input, @"\[[0-9,\s]*\]");
            if (matches.Count < 1) throw new ArgumentException(InvalidInput);

            var output = new List<int[]>();

            foreach (var match in matches)
            {
                output.Add(ConvertStringToIntArray(match.ToString()));
            }

            return output.ToArray();
        }

    }
}
