using Shared.Interfaces;

namespace February.Problems
{
    public class ValidAnagram : IProblem
    {
        public string Title => "Valid Anagram";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/585/week-2-february-8th-february-14th/3636/";

        public bool IsAnagram(string source, string target)
        {
            if (source.Length != target.Length) return false;

            var mp = new int[26];
            for (var i = 0; i < source.Length; i++)
            {
                var index1 = source[i] - 'a';
                mp[index1] = mp[index1] + 1;

                var index2 = target[i] - 'a';
                mp[index2] = mp[index2] - 1;
            }

            foreach (var item in mp)
            {
                if (item != 0) return false;
            }

            return true;
        }
    }
}
