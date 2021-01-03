using Shared.Helpers;
using Shared.Interfaces;

namespace January.Problems
{
    public class BeautifulArrangement : IProblem
    {
        public string Title => "Beautiful Arrangement";

        public string Url =>
            "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/579/week-1-january-1st-january-7th/3591/";

        public string CountArrangement(string input)
        {
            if (int.TryParse(input, out var value) && value >= 1 && value <= 15)
            {
                return CountArrangement(value).ToString();
            }
            return Messages.InvalidInput;
        }

        public int CountArrangement(int n)
        {
            var array = new int[n+1];
            for (var i = 1; i <= n; i++)
            {
                array[i] = i;
            }

            var result = 0;
            CountArrangement(array, n, ref result);
            return result;
        }

        private void CountArrangement(int[] array, int n, ref int result)
        {
            if (n == 0)
            {
                result++;
                return;
            }

            for (var i = n; i >0; i--)
            {
                Swap(array, i, n);
                if (array[n] % n == 0 | n % array[n] == 0)
                {
                    CountArrangement(array, n - 1, ref result);
                }
                Swap(array, n, i);
            }
        }

        private void Swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
