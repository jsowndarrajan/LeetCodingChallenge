using Shared.Models;
using System.Collections.Generic;

namespace Shared.Helpers
{
    public static class TreeHelper
    {
        public static bool IsSymmetricTree(TreeNode expected, TreeNode actual)
        {
            if (expected == null && actual == null) return true;

            if (expected == null || actual == null) return false;

            return (expected.Value == actual.Value
                    && IsSymmetricTree(expected.Left, actual.Left)
                    && IsSymmetricTree(expected.Right, actual.Right));
        }

        public static TreeNode ConstructLevelOrderTree(string[] nodes, int index)
        {
            if (nodes.Length < 1 ||
                nodes.Length < index ||
                nodes[index - 1].Trim().ToLower() == Messages.Null ||
                !int.TryParse(nodes[index - 1], out var value)) return null;

            var childIndex = 2 * index;
            var node = new TreeNode(value)
            {
                Left = ConstructLevelOrderTree(nodes, childIndex),
                Right = ConstructLevelOrderTree(nodes, childIndex + 1)
            };

            return node;
        }

        public static TreeNode ConstructLevelOrderTree(string[] nodes, int index, TreeNode targetNode)
        {
            if (nodes.Length < 1 ||
                nodes.Length < index ||
                nodes[index - 1].Trim().ToLower() == Messages.Null ||
                !int.TryParse(nodes[index - 1], out var value)) return null;

            var childIndex = 2 * index;

            var node = (value == targetNode.Value) ? targetNode : new TreeNode(value);
            node.Left = ConstructLevelOrderTree(nodes, childIndex, targetNode);
            node.Right = ConstructLevelOrderTree(nodes, childIndex + 1, targetNode);

            return node;
        }

        public static List<int?> ConstructLevelOrderTree(TreeNode root)
        {
            var list = new List<int?>();
            ConstructLevelOrderTree(root, list);
            return list;
        }

        private static void ConstructLevelOrderTree(TreeNode root, List<int?> result)
        {
            if (root == null)
            {
                result.Add(null);
                return;
            }
            result.Add(root.Value);
            ConstructLevelOrderTree(root.Left, result);
            ConstructLevelOrderTree(root.Right, result);
        }
    }
}