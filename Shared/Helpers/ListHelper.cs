using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Shared.Models;

namespace Shared.Helpers
{
    public class ListHelper
    {
        public static ListNode ConvertStringArrayToListNode(string inputArray)
        {
            var input = DataConverter.ConvertStringToIntArray(inputArray);

            ListNode headNode = null;
            ListNode tailNode = null;
            foreach (var item in input)
            {
                var node = new ListNode(item);
                if (headNode != null)
                {
                    tailNode.Next = node;
                    tailNode = tailNode.Next;
                }
                else
                {
                    headNode = node;
                    tailNode = node;
                }
            }
            return headNode;
        }

        public static ListNode[] ConvertStringArrayToListNodes(string input)
        {
            var matches = Regex.Matches(input, @"\[[0-9\-,\s]*\]");
            if (matches.Count < 1) throw new ArgumentException(Messages.InvalidInput);

            var output = new List<ListNode>();

            foreach (var match in matches)
            {
                output.Add(ConvertStringArrayToListNode(match.ToString()));
            }

            return output.ToArray();
        }
    }
}