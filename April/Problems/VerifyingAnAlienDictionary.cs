using Shared.Interfaces;

namespace April.Problems
{
    public class VerifyingAnAlienDictionary : IProblem
    {
        public string Title => "Verifying an Alien Dictionary";
        public string Url => "https://leetcode.com/explore/challenge/card/april-leetcoding-challenge-2021/594/week-2-april-8th-april-14th/3702/";

        public bool IsAlienSorted(string[] words, string order)
        {
            var map = new int[26];
            for (var i = 0; i < order.Length; i++)
            {
                map[order[i] - 'a'] = i;
            }

            for (var i = 0; i < words.Length - 1; i++)
            {
                for (var j = 0; j < words[i].Length; j++)
                {
                    if (j >= words[i + 1].Length) return false;

                    if (map[words[i][j] - 'a'] < map[words[i + 1][j] - 'a']) break;

                    if (map[words[i][j] - 'a'] > map[words[i + 1][j] - 'a']) return false;
                }
            }
            return true;
        }
    }
}
