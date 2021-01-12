using System;
using Shared.Helpers;
using Shared.Interfaces;
using Shared.Models;

namespace January.Problems
{
    public class AddTwoNumbersFromLinkedList : IProblem
    {
        public string Title => "Add Two Numbers";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/580/week-2-january-8th-january-14th/3601/";

        public string AddTwoNumbers(string l1, string l2)
        {
            try
            {
                var list1 = ListHelper.ConvertStringArrayToListNode(l1);
                var list2 = ListHelper.ConvertStringArrayToListNode(l2);
                var result = AddTwoNumbers(list1, list2);
                return $"[{result}]";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var carry = 0;
            var head = new ListNode();
            var current = head;

            while (l1 != null || l2 != null)
            {
                var sum = carry;
                if (l1 != null)
                {
                    sum += l1.Value;
                }

                if (l2 != null)
                {
                    sum += l2.Value;
                }
                var val = sum % 10;
                current.Next = new ListNode(val);
                current = current.Next;
                carry = sum / 10;
                l1 = l1?.Next;
                l2 = l2?.Next;
            }

            if (carry > 0)
            {
                current.Next = new ListNode(carry);
            }

            return head.Next;
        }
    }
}
