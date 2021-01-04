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
    }
}