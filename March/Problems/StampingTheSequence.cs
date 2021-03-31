using System;
using Shared.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace March.Problems
{
    public class StampingTheSequence : IProblem
    {
        public string Title => "Stamping The Sequence";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/592/week-5-march-29th-march-31st/3691/";

        public int[] MovesToStamp(string stamp, string target)
        {
            var output = new Stack<int>();
            var targetArray = target.ToCharArray();
            var outputString = new char[targetArray.Length];
            Array.Fill(outputString, '?');

            while (!targetArray.SequenceEqual(outputString))
            {
                var stampIndex = FindStampIndex(targetArray, stamp);

                if (stampIndex < 0)
                {
                    return new int[0];
                }
                Update(targetArray, stampIndex, stamp.Length);
                output.Push(stampIndex);
            }
            return output.ToArray();
        }

        private int FindStampIndex(char[] targetArray, string stamp)
        {
            for (var i = 0; i <= targetArray.Length - stamp.Length; i++)
            {
                var j = 0;
                var s = i;
                var isNonStarChar = false;

                while (j < stamp.Length 
                       && s < targetArray.Length
                       && (targetArray[s] == '?' || targetArray[s] == stamp[j]))
                {
                    if (targetArray[s] != '?')
                    {
                        isNonStarChar = true;
                    }

                    j++;
                    s++;
                    
                }

                if (j == stamp.Length && isNonStarChar)
                {
                    return i;
                }
            }
            return -1;
        }


        private void Update(char[] targetArray, int start, int end)
        {
            for (var i = 0; i < end; i++)
            {
                targetArray[i + start] = '?';
            }
        }
    }
}
