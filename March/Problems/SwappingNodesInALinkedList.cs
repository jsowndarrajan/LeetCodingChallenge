using Shared.Interfaces;
using Shared.Models;

namespace March.Problems
{
    public class SwappingNodesInALinkedList : IProblem
    {
        public string Title => "Swapping Nodes in a Linked List";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/589/week-2-march-8th-march-14th/3671/";

        public ListNode SwapNodes(ListNode head, int k)
        {
            var fromStart = head;
            for (var i = 1; i < k; i++)
            {
                fromStart = fromStart.Next;
            }
            var firstNode = fromStart;


            var fromEnd = head;
            while (fromStart.Next != null)
            {
                fromStart = fromStart.Next;
                fromEnd = fromEnd.Next;
            }

            var temp = firstNode.Value;
            firstNode.Value = fromEnd.Value;
            fromEnd.Value = temp;

            return head;
        }
    }
}
