using Shared.Interfaces;
using Shared.Models;

namespace April.Problems
{
    public class PalindromeLinkedList : IProblem
    {
        public string Title => "Palindrome Linked List";
        public string Url => "https://leetcode.com/explore/challenge/card/april-leetcoding-challenge-2021/593/week-1-april-1st-april-7th/3693/";

        public bool IsPalindrome(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            var secondHalf = Reverse(slow);

            while (secondHalf != null)
            {
                if (secondHalf.Value != head.Value)
                {
                    return false;
                }

                secondHalf = secondHalf.Next;
                head = head.Next;
            }
            return true;
        }

        private ListNode Reverse(ListNode mid)
        {
            ListNode previous = null;
            while (mid != null)
            {
                var current = mid;
                mid = mid.Next;
                current.Next = previous;
                previous = current;
            }

            return previous;
        }
    }
}
