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

        public static Node ConvertStringToListNodeWithRandomPointer(string input)
        {
            var matches = Regex.Matches(input, @"\[[0-9\-,\s\w]*\]");
            if (matches.Count < 1) throw new ArgumentException(Messages.InvalidInput);

            var map = new Dictionary<int, Node>();

            var index = 0;
            foreach (var match in matches)
            {
                var node = match.ToString();
                node = node.TrimStart('[');
                node = node.TrimEnd(']');
                var values = node.Split(',');
                if (values.Length != 2) throw new ArgumentException(Messages.InvalidInput);

                if (int.TryParse(values[0], out int value))
                {
                    if (map.ContainsKey(index))
                    {
                        map[index].Value = value;
                    }
                    else
                    {
                        map.Add(index, new Node(value));
                    }

                    if (int.TryParse(values[1], out int randomIndex))
                    {
                        if (!map.ContainsKey(randomIndex))
                        {
                            map.Add(randomIndex, new Node(value));
                        }

                        map[index].Random = map[randomIndex];
                    }

                    if (index > 0)
                    {
                        map[index - 1].Next = map[index];
                    }

                    index++;
                }
                else
                {
                    throw new ArgumentException(Messages.InvalidInput);
                }
            }

            return map[0];
        }

        public static string ConvertNodeWithRandomPointerToString(Node input)
        {
            if (input == null) return "[]";
            var map = new Dictionary<Node, int>();
            var index = 0;
            while (input != null)
            {
                map.Add(input, index++);
                input = input.Next;
            }

            var output = string.Empty;
            foreach (var item in map)
            {
                if (item.Key.Random is null)
                {
                    output += $"[{item.Key.Value}, null],";
                }
                else
                {
                    output += $"[{item.Key.Value},{map[item.Key.Random]}],";
                }
            }
            return $"[{output.TrimEnd(',')}]";
        }
    }
}