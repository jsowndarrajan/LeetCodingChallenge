using System;
using Shared.Helpers;
using Shared.Interfaces;
using Shared.Models;

namespace January.Problems
{
    public class RemoveDuplicatesFromList : IProblem
    {
        public string Title => "Remove duplicates from list";
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
