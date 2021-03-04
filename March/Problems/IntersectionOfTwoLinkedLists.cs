using System;
using Shared.Interfaces;
using Shared.Models;
using System.Collections.Generic;
using Shared.Helpers;

namespace March.Problems
{
    public class IntersectionOfTwoLinkedLists : IProblem
    {
        public string Title => "Intersection of Two Linked Lists";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/588/week-1-march-1st-march-7th/3660/";

        public string GetIntersectionNode(string input1, string input2)
        {
            try
            {
                var headA = ListHelper.ConvertStringArrayToListNode(input1);
                var headB = ListHelper.ConvertStringArrayToListNode(input2);
                var result = GetIntersectionNode(headA, headB);
                return result is null ? "null" : result.Value.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var hashset = new HashSet<ListNode>();
            while (headA != null)
            {
                var node = headA;
                hashset.Add(node);
                headA = headA.Next;
            }

            while (headB != null)
            {
                var node = headB;
                if (hashset.Contains(node))
                {
                    return node;
                }
                headB = headB.Next;
            }
            return null;
        }
    }
}
