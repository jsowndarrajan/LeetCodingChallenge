using Shared.Interfaces;
using System.Collections.Generic;

namespace March.Problems
{
    public class UndergroundSystem : IProblem
    {
        public string Title => "Design Underground System";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/590/week-3-march-15th-march-21st/3678/";
        
        public Dictionary<int, StationAndTimePair> CheckInMap { get; }
        public Dictionary<string, Dictionary<string, ResultPair>> AverageTimeMap { get; }

        public UndergroundSystem()
        {
            CheckInMap = new Dictionary<int, StationAndTimePair>();
            AverageTimeMap = new Dictionary<string, Dictionary<string, ResultPair>>();
        }

        public void CheckIn(int id, string stationName, int t)
        {
            if (!CheckInMap.ContainsKey(id))
            {
                CheckInMap[id] = new StationAndTimePair();
            }
            CheckInMap[id].StationName = stationName;
            CheckInMap[id].Time = t;
        }

        public void CheckOut(int id, string stationName, int t)
        {
            if (CheckInMap.ContainsKey(id))
            {
                var startStation = CheckInMap[id].StationName;
                var startTime = CheckInMap[id].Time;

                var distance = t - startTime;

                if (!AverageTimeMap.ContainsKey(startStation))
                {
                    AverageTimeMap.Add(startStation, new Dictionary<string, ResultPair>());
                }
                    
                if (!AverageTimeMap[startStation].ContainsKey(stationName))
                {
                    AverageTimeMap[startStation].Add(stationName, new ResultPair());
                }

                AverageTimeMap[startStation][stationName].NumberOfSets += 1;
                AverageTimeMap[startStation][stationName].TotalDifference += distance;
            }
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            return AverageTimeMap[startStation][endStation].TotalDifference /
                   AverageTimeMap[startStation][endStation].NumberOfSets;
        }

        public class ResultPair
        {
            public int NumberOfSets { get; set; }
            public double TotalDifference { get; set; }
        }

        public class StationAndTimePair
        {
            public string StationName { get; set; }

            public int Time { get; set; }
        }
    }
}
