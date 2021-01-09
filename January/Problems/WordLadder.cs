using System;
using Shared.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Shared.Helpers;

namespace January.Problems
{
    public class WordLadder : IProblem
    {
        public string Title => "Word Ladder";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/580/week-2-january-8th-january-14th/3598/";

        public string LadderLength(string beginWord, string endWord, string wordList)
        {
            try
            {
                var words = DataConverter.ConvertStringToStringArray(wordList).ToList();
                return LadderLength(beginWord, endWord, words).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (beginWord.Length == 0 || endWord.Length == 0 || wordList.Count == 0)
                return 0;

            var set = new HashSet<string>();
            foreach (var word in wordList)
            {
                set.Add(word);
            }

            if (!set.Contains(endWord))
            {
                return 0;
            }

            var level = 1;
            var queue = new Queue<string>();
            queue.Enqueue(beginWord);

            while (queue.Count != 0)
            {
                level += 1;
                

                var levelSize = queue.Count;
                while (levelSize != 0)
                {
                    var word = queue.Dequeue();
                    var characters = word.ToCharArray();

                    for (var i = 0; i < word.Length; i++)
                    {
                        var initCharacter = characters[i];
                        for (var j = 'a'; j <= 'z'; j++)
                        {
                            if (word[i] == j) continue;

                            characters[i] = j;

                            var newWord = new string(characters);
                            if (set.Contains(newWord))
                            {
                                set.Remove(newWord);
                                queue.Enqueue(newWord);
                            }

                            if (newWord == endWord) return level;

                            characters[i] = initCharacter;
                        }
                    }

                    levelSize -= 1;
                }
            }
            return 0;
        }
    }
}
