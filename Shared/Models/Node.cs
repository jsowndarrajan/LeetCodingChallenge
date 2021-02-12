namespace Shared.Models
{
    public class Node
    {
        public int Value;
        public Node Next;
        public Node Random;

        public Node(int value)
        {
            Value = value;
            Next = null;
            Random = null;
        }
    }
}
