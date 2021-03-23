using Shared.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace March.Problems
{
    public class VowelSpellchecker : IProblem
    {
        public string Title => "Vowel Spellchecker";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/591/week-4-march-22nd-march-28th/3681/";
        
        private readonly HashSet<char> _vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        public string[] Spellchecker(string[] wordList, string[] queries)
        {
            var hashset = new HashSet<string>();
            var caseInsensitiveWords = new Dictionary<string, string>();
            var wordsWithoutVowels = new Dictionary<string, string>();

            foreach (var word in wordList)
            {
                hashset.Add(word);
                var lowerCaseWord = word.ToLower();
                if (!caseInsensitiveWords.ContainsKey(lowerCaseWord))
                {
                    caseInsensitiveWords.Add(lowerCaseWord, word);
                }

                var wordWithoutVowels = RemoveVowel(lowerCaseWord);
                if (!wordsWithoutVowels.ContainsKey(wordWithoutVowels))
                {
                    wordsWithoutVowels.Add(wordWithoutVowels, word);
                }
            }

            var result = new string[queries.Length];
            for (var i = 0; i < queries.Length; i++)
            {
                if (hashset.Contains(queries[i]))
                {
                    result[i] = queries[i];
                    continue;
                }

                var lowerCaseQuery = queries[i].ToLower();
                if (caseInsensitiveWords.ContainsKey(lowerCaseQuery))
                {
                    result[i] = caseInsensitiveWords[lowerCaseQuery];
                    continue;
                }

                var wordWithoutVowel = RemoveVowel(lowerCaseQuery);
                if (wordsWithoutVowels.ContainsKey(wordWithoutVowel))
                {
                    result[i] = wordsWithoutVowels[wordWithoutVowel];
                }
                else
                {
                    result[i] = string.Empty;
                }
            }

            return result;
        }

        private string RemoveVowel(string word)
        {
            var newString = new StringBuilder();
            foreach (var @char in word)
            {
                if (IsVowel(@char))
                {
                    newString.Append("#");
                }
                else
                {
                    newString.Append(@char);
                }
            }
            return newString.ToString();
        }

        public bool IsVowel(char @char)
        {
            return _vowels.Contains(@char);
        }
    }
}
