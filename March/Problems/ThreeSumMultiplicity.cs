using Shared.Interfaces;
using System.Collections.Generic;

namespace March.Problems
{
    public class ThreeSumMultiplicity : IProblem
    {
        public string Title => "3Sum With Multiplicity";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/591/week-4-march-22nd-march-28th/3682/";

        public int Calculate(int[] arr, int target)
        {
            long output = 0;
            var map = new Dictionary<int, long>();
            for (var i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    map[arr[i]] += 1;
                }
                else
                {
                    map.Add(arr[i], 1);
                }
            }

            foreach (var kvp1 in map)
            {
                foreach (var kvp2 in map)
                {
                    var thirdElementValue = target - kvp1.Key - kvp2.Key;

                    if (map.ContainsKey(thirdElementValue))
                    {
                        if (kvp1.Key == kvp2.Key && kvp2.Key == thirdElementValue)
                        {
                            // Combinations
                            // TC1: All are same numbers
                            // nCr => n!/r!(n-r)!
                            // n => total of number frequency
                            // r => count of selected numbers from the set
                            output += ((kvp1.Value) * (kvp1.Value - 1) * (kvp1.Value - 2)) / 6;
                        }
                        else if (kvp1.Key == kvp2.Key && kvp2.Key != thirdElementValue)
                        {
                            //TC2: First two elements is same
                            output += ((kvp1.Value) * (kvp1.Value - 1) / 2) * map[thirdElementValue];
                        }
                        else if (kvp1.Key < kvp2.Key && kvp2.Key < thirdElementValue)
                        {
                            output += kvp1.Value * kvp2.Value * map[thirdElementValue];
                        }
                    }

                    output = output % 1000000007;
                }
            }
            return (int)output;
        }
    }
}
