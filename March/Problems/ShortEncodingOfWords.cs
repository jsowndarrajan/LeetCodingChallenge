using Shared.Helpers;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using Shared.Extensions;

namespace March.Problems
{
    public class ShortEncodingOfWords : IProblem
    {
        public string Title => "Short Encoding of Words";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/588/week-1-march-1st-march-7th/3662/";

        private delegate int MinimumLengthEncodingDelegate(string[] words);
        private MinimumLengthEncodingDelegate[] Delegates => new MinimumLengthEncodingDelegate[]
        {
            MinimumLengthEncodingByUsingTrie,
            MinimumLengthEncodingByUsingSet
        };

        public string MinimumLengthEncoding(string input)
        {
            try
            {
                var words = DataConverter.ConvertStringToStringArray(input);
                var method = Delegates.GetRandom();
                var result = method.Invoke(words);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int MinimumLengthEncodingByUsingTrie(string[] words)
        {
            var root = new TrieNode();
            var map = new Dictionary<TrieNode, int>();
            for (var i = 0; i < words.Length; i++)
            {
                var current = root;
                for (var j = words[i].Length - 1; j >= 0; j--)
                {
                    current = current.Get(words[i][j]);
                }
                if (!map.ContainsKey(current))
                {
                    map.Add(current, i);
                }
            }

            var output = 0;
            foreach (var kvp in map)
            {
                if (kvp.Key.Count == 0)
                {
                    output += words[kvp.Value].Length + 1;
                }
            }
            return output;
        }

        public int MinimumLengthEncodingByUsingSet(string[] words)
        {
            var set = new HashSet<string>(words);
            foreach (var word in words)
            {
                for (var i = 1; i < word.Length; i++)
                {
                    var substring = word.Substring(i);
                    set.Remove(substring);
                }
            }

            var output = 0;
            foreach (var item in set)
            {
                output += item.Length + 1;
            }
            return output;
        }
    }
}
