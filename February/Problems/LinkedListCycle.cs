using Shared.Helpers;
using Shared.Interfaces;
using Shared.Models;
using System;

namespace February.Problems
{
    public class LinkedListCycle : IProblem
    {
        public string Title => "Linked List Cycle";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/584/week-1-february-1st-february-7th/3627/";

        public string HasCycle(string input, string position)
        {
            try
            {
                var pos = Convert.ToInt32(position);
                var head = FormListNode(input, pos);
                var result = HasCycle(head);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private static ListNode FormListNode(string input, int pos)
        {
            var head = ListHelper.ConvertStringArrayToListNode(input);
            if (pos < 0) return head;

            var cyclicNode = GetCyclicNode(pos, head);
            CreateCyclicList(head, cyclicNode);
            return head;
        }

        private static void CreateCyclicList(ListNode node, ListNode cyclicNode)
        {
            var tail = node;
            while (tail.Next != null)
            {
                tail = tail.Next;
            }

            tail.Next = cyclicNode;
        }

        private static ListNode GetCyclicNode(int pos, ListNode node)
        {
            var position = -1;
            var current = node;
            while (current != null)
            {
                position++;
                if (position == pos)
                {
                    break;
                }

                current = current.Next;
            }
            return position == -1 ? null : current;
        }

        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;

            var slowNode = head;
            var fastNode = head.Next;

            while (fastNode?.Next != null)
            {
                if (slowNode == fastNode) return true;
                slowNode = slowNode.Next;
                fastNode = fastNode.Next.Next;
            }
            return false;
        }
    }
}
