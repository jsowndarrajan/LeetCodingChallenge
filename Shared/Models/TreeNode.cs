namespace Shared.Models
{
    public class TreeNode
    {
        public int Value { get; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int value, TreeNode left = null, TreeNode right = null)
        {
            Left = left;
            Right = right;
            Value = value;
        }
    }
}