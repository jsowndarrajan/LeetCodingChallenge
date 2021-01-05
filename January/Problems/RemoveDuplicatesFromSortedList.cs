using System;
using Shared.Helpers;
using Shared.Interfaces;
using Shared.Models;

namespace January.Problems
{
    public class RemoveDuplicatesFromSortedList : IProblem
    {
        public string Title => "Remove duplicates from sorted list";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/579/week-1-january-1st-january-7th/3593/";

        public string DeleteDuplicates(string inputArray)
        {
            try
            {
                var listNode = ListHelper.ConvertStringArrayToListNode(inputArray);
                var result = DeleteDuplicates(listNode);
                return $"[{result}]";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            // sentinel
            ListNode sentinel = new ListNode(0, head);

            // predecessor = the last node 
            // before the sublist of duplicates
            ListNode pred = sentinel;

            while (head != null)
            {
                // if it's a beginning of duplicates sublist 
                // skip all duplicates
                if (head.Next != null && head.Value == head.Next.Value)
                {
                    // move till the end of duplicates sublist
                    while (head.Next != null && head.Value == head.Next.Value)
                    {
                        head = head.Next;
                    }
                    // skip all duplicates
                    pred.Next = head.Next;
                    // otherwise, move predecessor
                }
                else
                {
                    pred = pred.Next;
                }

                // move forward
                head = head.Next;
            }
            return sentinel.Next;
        }

        public ListNode DeleteDuplicates1(ListNode head)
        {
            var currentNode = head;
            ListNode duplicateNode = null;
            ListNode startNode = null;
            ListNode tailNode = null;
            while (currentNode != null)
            {
                if (currentNode.Value == currentNode.Next?.Value || 
                    (duplicateNode != null && duplicateNode.Value == currentNode.Value))
                {
                    duplicateNode = currentNode;
                    currentNode = currentNode.Next;
                    if (tailNode != null)
                    {
                        tailNode.Next = currentNode;
                    }
                    continue;
                }

                if (startNode == null)
                {
                    startNode = currentNode;
                    tailNode = startNode;
                }
                else
                {
                    tailNode.Next = currentNode;
                    tailNode = tailNode.Next;
                }

                currentNode = currentNode.Next;
            }
            return startNode;
        }
    }
}
