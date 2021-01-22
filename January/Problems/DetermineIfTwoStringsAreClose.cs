using System;
using Shared.Interfaces;

namespace January.Problems
{
    public class DetermineIfTwoStringsAreClose : IProblem
    {
        public string Title => "Determine if Two Strings Are Close";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/582/week-4-january-22nd-january-28th/3613/";

        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length) return false;

            var charactersCountInWord1 = new int[26];
            var charactersCountInWord2 = new int[26];
            var availableCharactersInWord1 = new bool[26];
            var availableCharactersInWord2 = new bool[26];

            for (var i = 0; i < word1.Length; i++)
            {
                var index1 = word1[i] - 'a';
                var index2 = word2[i] - 'a';
                charactersCountInWord1[index1] += 1;
                charactersCountInWord2[index2] += 1;
                availableCharactersInWord1[index1] = true;
                availableCharactersInWord2[index2] = true;
            }

            Array.Sort(charactersCountInWord1);
            Array.Sort(charactersCountInWord2);

            for (var i = 0; i < 26; i++)
            {
                if (!(charactersCountInWord1[i] == charactersCountInWord2[i]
                    &&
                    availableCharactersInWord1[i] == availableCharactersInWord2[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
