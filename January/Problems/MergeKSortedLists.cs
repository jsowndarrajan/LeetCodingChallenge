using System;
using Shared.Helpers;
using Shared.Interfaces;
using Shared.Models;

namespace January.Problems
{
    public class MergeKSortedLists : IProblem
    {
        public string Title => "Merge k Sorted Lists";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/582/week-4-january-22nd-january-28th/3615/";

        public string MergeKLists(string input)
        {
            try
            {
                var lists = ListHelper.ConvertStringArrayToListNodes(input);
                var result = MergeKLists(lists);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0) return null;
            return BinaryMerge(lists, 0, lists.Length - 1);
        }

        public ListNode BinaryMerge(ListNode[] lists, int start, int end)
        {
            if (start == end) return lists[start];
            int mid = start + (end - start) / 2;
            var left = BinaryMerge(lists, start, mid);
            var right = BinaryMerge(lists, mid + 1, end);
            return MergeTwoLists(left, right);
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode resultHeadNode = null;
            ListNode resultTailNode = null;

            while (l1 != null && l2 != null)
            {
                if (l1.Value < l2.Value)
                {
                    if (resultHeadNode == null)
                    {
                        resultHeadNode = l1;
                        l1 = l1.Next;
                        resultTailNode = resultHeadNode;
                    }
                    else
                    {
                        resultTailNode.Next = l1;
                        l1 = l1.Next;
                        resultTailNode = resultTailNode.Next;
                    }
                }
                else
                {
                    if (resultHeadNode == null)
                    {
                        resultHeadNode = l2;
                        l2 = l2.Next;
                        resultTailNode = resultHeadNode;
                    }
                    else
                    {
                        resultTailNode.Next = l2;
                        l2 = l2.Next;
                        resultTailNode = resultTailNode.Next;
                    }
                }
            }

            if (l1 == null && l2 != null)
            {
                if (resultHeadNode == null)
                {
                    resultHeadNode = l2;
                }
                else
                {
                    resultTailNode.Next = l2;
                }
            }

            if (l2 == null && l1 != null)
            {
                if (resultHeadNode == null)
                {
                    resultHeadNode = l1;
                }
                else
                {
                    resultTailNode.Next = l1;
                }
            }

            return resultHeadNode;
        }
    }
}
