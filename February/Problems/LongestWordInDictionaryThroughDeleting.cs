using System;
using Shared.Interfaces;
using System.Collections.Generic;
using Shared.Helpers;

namespace February.Problems
{
    public class LongestWordInDictionaryThroughDeleting : IProblem
    {
        public string Title => "Longest Word in Dictionary through Deleting";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/587/week-4-february-22nd-february-28th/3649/";

        public string FindLongestWord(string input, string wordList)
        {
            try
            {
                var d = DataConverter.ConvertStringToStringArray(wordList);
                return FindLongestWord(input, d);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string FindLongestWord(string s, IList<string> d)
        {
            var output = string.Empty;
            foreach (var word in d)
            {
                if(word.Length > s.Length) continue;
                if(word.Length == s.Length && word != s) continue;

                if (!IsSubsequence(s, word)) continue;

                if (word.Length > output.Length)
                {
                    output = word;
                }
                else if (word.Length == output.Length)
                {
                    output = string.Compare(word, output) == 1 ? output : word;
                }
            }
            return output;
        }

        private static bool IsSubsequence(string s, string word)
        {
            var index1 = 0;
            var index2 = 0;
            var matchedCharactersCount = 0;
            while (index1 < word.Length && index2 < s.Length)
            {
                if (word[index1] == s[index2])
                {
                    index1++;
                    matchedCharactersCount++;
                }
                index2++;
            }
            return matchedCharactersCount == word.Length;
        }
    }
}
