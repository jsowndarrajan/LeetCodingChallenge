using Shared.Interfaces;
using Shared.Models;

namespace April.Problems
{
    public class PartitionList : IProblem
    {
        public string Title => "Partition List";
        public string Url => "https://leetcode.com/explore/challenge/card/april-leetcoding-challenge-2021/594/week-2-april-8th-april-14th/3707/";

        public ListNode Partition(ListNode head, int x)
        {
            ListNode firstHalfStart = new ListNode(-1);
            ListNode firstHalfEnd = firstHalfStart;

            ListNode secondHalfStart = new ListNode(-1);
            ListNode secondHalfEnd = secondHalfStart;

            while (head != null)
            {
                if (head.Value < x)
                {
                    firstHalfEnd.Next = head;
                    firstHalfEnd = firstHalfEnd.Next;
                }
                else
                {
                    secondHalfEnd.Next = head;
                    secondHalfEnd = secondHalfEnd.Next;
                }
                head = head.Next;
            }

            firstHalfEnd.Next = secondHalfStart.Next;
            secondHalfEnd.Next = null;

            return firstHalfStart.Next;
        }
    }
}
