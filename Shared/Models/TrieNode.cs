namespace Shared.Models
{
    public class TrieNode
    {
        private readonly TrieNode[] _children = new TrieNode[26];
        public int Count;

        public TrieNode Get(char @char)
        {
            var index = @char - 'a';
            if (_children[index] == null)
            {
                _children[index] = new TrieNode();
                Count++;
            }
            return _children[index];
        }

    }
}
