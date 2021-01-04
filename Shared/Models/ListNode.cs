namespace Shared.Models
{
    public class ListNode
    {
        public int Value;
        public ListNode Next;
        public ListNode(int val = 0, ListNode next = null)
        {
            Value = val;
            Next = next;
        }

        public override string ToString()
        {
            var result = Value.ToString();

            if (Next != null)
            {
                result += "," + Next;
            }

            return result;
        }
    }
}
