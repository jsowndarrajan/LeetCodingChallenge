using Shared.Helpers;
using Shared.Interfaces;
using Shared.Models;
using System;

namespace January.Problems
{
    public class MergeTwoSortedLists: IProblem
    {
        public string Title => "Merge Two Sorted Lists";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/579/week-1-january-1st-january-7th/3592/";

        public string MergeTwoLists(string inputArray1, string inputArray2)
        {
            try
            {
                var l1 = ListHelper.ConvertStringArrayToListNode(inputArray1);
                var l2 = ListHelper.ConvertStringArrayToListNode(inputArray2);

                var result = MergeTwoLists(l1, l2);
                return $"[{result}]";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
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
