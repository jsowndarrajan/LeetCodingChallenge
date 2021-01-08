using Shared.Helpers;
using Shared.Interfaces;
using System;
using System.Collections.Generic;

namespace January.Problems
{
    public class CheckIfTwoStringArraysAreEquivalent : IProblem
    {
        public string Title => "Check If Two String Arrays are Equivalent";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/580/week-2-january-8th-january-14th/3597/";

        public string ArrayStringsAreEqual(string word1, string word2)
        {
            try
            {
                var array1 = DataConverter.ConvertStringToStringArray(word1);
                var array2 = DataConverter.ConvertStringToStringArray(word2);
                return ArrayStringsAreEqual(array1, array2).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            using var w1 = IterateWords(word1).GetEnumerator();
            using var w2 = IterateWords(word2).GetEnumerator();

            var hasCharacterInWord1 = w1.MoveNext();
            var hasCharacterInWord2 = w2.MoveNext();

            while (hasCharacterInWord1 && hasCharacterInWord2)
            {
                var char1 = w1.Current;
                var char2 = w2.Current;
                if (char1 != char2) return false;

                hasCharacterInWord1 = w1.MoveNext();
                hasCharacterInWord2 = w2.MoveNext();
            }
            return hasCharacterInWord1 == hasCharacterInWord2;
        }

        public IEnumerable<char> IterateWords(string[] words)
        {
            foreach (var word in words)
            {
                foreach (var character in word)
                {
                    yield return character;
                }
            }
        }
    }
}
