using Shared.Helpers;
using Shared.Interfaces;

namespace February.Problems
{
    public class BrokenCalculator : IProblem
    {
        public string Title => "Broken Calculator";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/586/week-3-february-15th-february-21st/3647/";

        public string BrokenCalc(string X, string Y)
        {
            if (int.TryParse(X, out var x) && int.TryParse(Y, out var y))
            {
                var result = BrokenCalc(x, y);
                return result.ToString();
            }
            else
            {
                return Messages.InvalidInput;
            }
        }

        public int BrokenCalc(int x, int y)
        {
            if (x >= y)
            {
                return x - y;
            }

            var output = 0;
            while (x < y)
            {
                if (y % 2 == 0)
                {
                    y /= 2;
                }
                else
                {
                    y = y + 1;
                }

                output++;
            }

            return output + (x-y);
        }
    }
}
