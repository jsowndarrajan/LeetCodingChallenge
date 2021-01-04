using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Shared.Models;

namespace Shared.Helpers
{
    public class DataConverter
    {
        public static int[] ConvertStringToIntArray(string input)
        {
            var match = Regex.Match(input.Trim(), @"\[([0-9,\-\s]*)\]");
            if (!match.Success) throw new ArgumentException(Messages.InvalidInput);

            try
            {
                if (match.Groups.Count == 2 &&
                   string.IsNullOrWhiteSpace(match.Groups[1].Value))
                    return new int[] { };

                return match.Groups[1].Value
                    .Split(',')
                    .Select(x => int.Parse(x.Trim()))
                    .ToArray();
            }
            catch (Exception)
            {
                throw new ArgumentException(Messages.InvalidInput);
            }
        }

        public static int[][] ConvertStringToNestedArray(string input)
        {
            var matches = Regex.Matches(input, @"\[[0-9,\s]*\]");
            if (matches.Count < 1) throw new ArgumentException(Messages.InvalidInput);

            var output = new List<int[]>();

            foreach (var match in matches)
            {
                output.Add(ConvertStringToIntArray(match.ToString()));
            }

            return output.ToArray();
        }

        public static TreeNode ConvertStringArrayToTreeNode(string binaryArray)
        {
            var match = Regex.Match(binaryArray.Trim(), @"\[(.*)\]");
            if (!match.Success) throw new ArgumentException(Messages.InvalidInput);

            var nodeStrings = match.Groups[1].Value.Split(',');
            return TreeHelper.ConstructLevelOrderTree(nodeStrings, 1);
        }

        public static TreeNode ConvertStringArrayToTreeNode(string binaryArray, TreeNode treeNode)
        {
            var match = Regex.Match(binaryArray.Trim(), @"\[(.*)\]");
            if (!match.Success) throw new ArgumentException(Messages.InvalidInput);

            var nodeStrings = match.Groups[1].Value.Split(',');
            return TreeHelper.ConstructLevelOrderTree(nodeStrings, 1, treeNode);
        }

        public static TreeNode ConvertStringNumberToTargetNode(string targetNumber)
        {
            return int.TryParse(targetNumber, out var value) ? new TreeNode(value) : null;
        }
    }
}
