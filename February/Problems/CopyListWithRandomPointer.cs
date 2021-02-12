using Shared.Helpers;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace February.Problems
{
    public class CopyListWithRandomPointer : IProblem
    {
        public string Title => "Copy List with Random Pointer";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/585/week-2-february-8th-february-14th/3635/";

        public string CopyRandomList(string input)
        {
            try
            {
                var head = ListHelper.ConvertStringToListNodeWithRandomPointer(input);
                var result = CopyRandomList(head);
                return ListHelper.ConvertNodeWithRandomPointerToString(result);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Node CopyRandomList(Node head)
        {
            var output = head;
            if (head == null) return output;

            var map = new Dictionary<Node, Node>();

            while (head != null)
            {
                map.Add(head, new Node(head.Value));
                head = head.Next;
            }

            head = output;
            while (head != null)
            {
                var newNode = map[head];
                if(head.Next != null) newNode.Next = map[head.Next];
                if (head.Random != null) newNode.Random = map[head.Random];
                head = head.Next;
            }
            return map[output];
        }
    }
}
