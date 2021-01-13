using Shared.Helpers;
using Shared.Interfaces;
using System;
using System.Collections.Generic;

namespace January.Problems
{
    public class CreateSortedArrayThroughInstructions : IProblem
    {
        public string Title => "Create Sorted Array through Instructions";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/580/week-2-january-8th-january-14th/3599/";

        public string CreateSortedArray(string instructions)
        {
            try
            {
                var array = DataConverter.ConvertStringToIntArray(instructions);
                var result = CreateSortedArray(array);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int CreateSortedArray(int[] instructions)
        {
            var max = 0;
            for (var i = 0; i < instructions.Length; i++)
            {
                max = Math.Max(max, instructions[i]);
            }

            var fenwick = new Fenwick(max + 2);

            var minCost = 0;
            for (var i = 0; i < instructions.Length; i++)
            {
                var current = instructions[i];
                var left = fenwick.SumRange(0, current - 1);
                var right = fenwick.SumRange(current + 1, max);
                minCost += Math.Min(left, right);
                minCost %= 1000000007;
                fenwick.Update(current, 1);
            }
            return minCost;
        }

        //Time Limit Exceeds
        public int CreateSortedArray2(int[] instructions)
        {
            var minCost = 0;
            var set = new SortedSet<int>(new DuplicateKeyComparer<int>());
            for (int i = 0; i < instructions.Length; i++)
            {
                var left = set.GetViewBetween(int.MinValue, instructions[i] - 1).Count;
                var right = set.GetViewBetween(instructions[i], int.MaxValue).Count;
                minCost += Math.Min(left, right);
                set.Add(instructions[i]);

                minCost %= (int)(Math.Pow(10, 9) + 7);
            }

            return minCost;
        }

        //Time Limit Exceeds
        public int CreateSortedArray1(int[] instructions)
        {
            var minCost = 0;
            if (instructions.Length == 0) return minCost;
            var sortedArray = new int[instructions.Length];
            sortedArray[0] = instructions[0];
            
            for (var i = 1; i < instructions.Length; i++)
            {
                var leftIndex = FindLeftIndexPositionToInsertAnItem(sortedArray, 0, i - 1, instructions[i]);
                var rightIndex = FindRightIndexPositionToInsertAnItem(sortedArray, 0, i - 1, instructions[i]);
                InsertIntoSortedArray(sortedArray, rightIndex, i, instructions[i]);
                minCost += Math.Min(leftIndex, i - rightIndex);
                minCost %= 1000000007;
            }
            return minCost;
        }

        private void InsertIntoSortedArray(int[] sortedArray, int insertIndex, int endIndex, int value)
        {
            for (var i = endIndex; i > insertIndex; i--)
            {
                sortedArray[i] = sortedArray[i - 1];
            }
            sortedArray[insertIndex] = value;
        }

        public int FindLeftIndexPositionToInsertAnItem(int[] sortedArray, int startIndex, int endIndex, int value)
        {
            if (startIndex > endIndex) return startIndex;

            var mid = startIndex + ((endIndex - startIndex) / 2);
            if (sortedArray[mid] == value)
            {
                var leftIndex = mid;
                while (leftIndex > 0 && sortedArray[leftIndex - 1] == value)
                {
                    --leftIndex;
                }

                return leftIndex;
            }

            return sortedArray[mid] < value 
                ? FindLeftIndexPositionToInsertAnItem(sortedArray, mid + 1, endIndex, value) 
                : FindLeftIndexPositionToInsertAnItem(sortedArray, startIndex, mid - 1, value);
        }

        public int FindRightIndexPositionToInsertAnItem(int[] sortedArray, int startIndex, int endIndex, int value)
        {

            if (startIndex > endIndex) return startIndex;

            var mid = startIndex + ((endIndex - startIndex) / 2);
            if (sortedArray[mid] == value)
            {
                var rightIndex = mid;
                while (sortedArray[++rightIndex] == value)
                {
                }
                return rightIndex;
            }

            return sortedArray[mid] < value
                ? FindRightIndexPositionToInsertAnItem(sortedArray, mid + 1, endIndex, value)
                : FindRightIndexPositionToInsertAnItem(sortedArray, startIndex, mid - 1, value);
        }
    }

    public class Fenwick
    {
        private readonly int[] arr;

        public Fenwick(int size)
        {
            arr = new int[size];
        }

        public int SumRange(int start, int end)
        {
            return Sum(end + 1) - Sum(start);
        }

        public int Sum(int index)
        {
            var sum = 0;
            while (index > 0)
            {
                sum += arr[index];
                index -= (index & -index);
            }
            return sum;
        }

        public void Update(int index, int value)
        {
            index++;
            while (index < arr.Length)
            {
                arr[index] += value;
                index += (index & -index);
            }
        }
    }

}
