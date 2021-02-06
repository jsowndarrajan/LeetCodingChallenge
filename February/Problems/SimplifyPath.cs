using System.Collections.Generic;
using Shared.Interfaces;

namespace February.Problems
{
    public class SimplifyPath : IProblem
    {
        public string Title => "Simplify Path";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/584/week-1-february-1st-february-7th/3629/";

        public string GenerateCanonicalPath(string input)
        {
            var commands = new Stack<string>();
            var paths = input.Split('/');
            foreach (var path in paths)
            {
                if(path == string.Empty) continue;
                switch (path)
                {
                    case "":
                    case ".":
                        break;
                    case "..":
                    {
                        if (commands.Count > 0)
                        {
                            commands.Pop();
                        }
                        break;
                    }
                    default:
                        commands.Push(path);
                        break;
                }
            }
            return ConvertToCanonicalPath(commands);
        }

        public string ConvertToCanonicalPath(Stack<string> stack)
        {
            if (stack.Count == 0) return "/";

            var result = string.Empty;
            while (stack.Count > 0)
            {
                var dirPath = stack.Pop();
                result = "/" + dirPath + result;
            }
            return result;
        }
    }
}
