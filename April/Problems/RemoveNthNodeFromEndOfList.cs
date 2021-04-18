using Shared.Interfaces;
using Shared.Models;

namespace April.Problems
{
    public class RemoveNthNodeFromEndOfList : IProblem
    {
        public string Title => "Remove Nth Node From End of List";
        public string Url => "https://leetcode.com/explore/challenge/card/april-leetcoding-challenge-2021/595/week-3-april-15th-april-21st/3712/";

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var output = new ListNode(-1, head);
            var thresholdPoint = output;
            while (n > 0)
            {
                thresholdPoint = thresholdPoint.Next;
                n--;
            }

            var current = output;
            while (thresholdPoint != null && thresholdPoint.Next != null)
            {
                current = current.Next;
                thresholdPoint = thresholdPoint.Next;
            }

            current.Next = current.Next.Next;

            return output.Next;
        }
    }
}
