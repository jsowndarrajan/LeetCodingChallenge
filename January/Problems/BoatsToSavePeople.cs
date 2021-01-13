using System;
using Shared.Helpers;
using Shared.Interfaces;

namespace January.Problems
{
    public class BoatsToSavePeople : IProblem
    {
        public string Title => "Boats to Save People";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/580/week-2-january-8th-january-14th/3602/";

        public string NumRescueBoats(string people, string limit)
        {
            try
            {
                var peopleArray = DataConverter.ConvertStringToIntArray(people);
                if (int.TryParse(limit, out int value))
                {
                    var result = NumRescueBoats(peopleArray, value);
                    return result.ToString();
                }

                return Messages.InvalidInput;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);

            var requiredBoats = 0;
            var start = 0;
            var end = people.Length - 1;
            while (start <= end)
            { 
                var sum = (start == end) ? people[start] : people[start] + people[end];

                if (sum <= limit)
                {
                    start++;
                    end--;
                }
                else
                {
                    end--;
                }
                requiredBoats++;
            }

            return requiredBoats;
        }
    }
}
