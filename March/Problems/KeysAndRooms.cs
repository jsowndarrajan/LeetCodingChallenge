using Shared.Interfaces;
using System.Collections.Generic;

namespace March.Problems
{
    public class KeysAndRooms : IProblem
    {
        public string Title => "Keys and Rooms";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/590/week-3-march-15th-march-21st/3677/";

        public bool CanVisitAllRooms(List<List<int>> rooms)
        {
            var noOfVisitedRooms = 0;
            var visited = new bool[rooms.Count];
            var availableRoomKeys = new Queue<int>();
            availableRoomKeys.Enqueue(0);

            while (availableRoomKeys.Count > 0)
            {
                var keyInHand = availableRoomKeys.Dequeue();
                if (!visited[keyInHand])
                {
                    noOfVisitedRooms++;
                    visited[keyInHand] = true;

                    foreach (var key in rooms[keyInHand])
                    {
                        if (!visited[key])
                        {
                            availableRoomKeys.Enqueue(key);
                        }
                    }
                }
            }

            return rooms.Count == noOfVisitedRooms;
        }
    }
}
