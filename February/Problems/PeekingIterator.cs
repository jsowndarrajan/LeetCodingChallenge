using Shared.Interfaces;
using System.Collections.Generic;

namespace February.Problems
{
    public class PeekingIterator : IProblem
    {
        public string Title => "Peeking Iterator";

        public string Url =>
            "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/585/week-2-february-8th-february-14th/3633/";

        private Queue<int> _cache;

        public PeekingIterator(IEnumerator<int> iterator)
        {
            _cache = new Queue<int>();
            while (iterator.MoveNext())
            {
                _cache.Enqueue(iterator.Current);
            }
        }

        // Returns the next element in the iteration without advancing the iterator.
        public int Peek()
        {
            return _cache.Peek();
        }

        // Returns the next element in the iteration and advances the iterator.
        public int Next()
        {
            return _cache.Dequeue();
        }

        // Returns false if the iterator is refering to the end of the array of true otherwise.
        public bool HasNext()
        {
            return _cache.Count > 0;
        }
    }

    public class PeekingIterator1 : IProblem
    {
        public string Title => "Peeking Iterator";

        public string Url =>
            "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/585/week-2-february-8th-february-14th/3633/";


        private bool moveNextCalled;
        private readonly IEnumerator<int> _iterator;


        public PeekingIterator1()
        {
        }

        public PeekingIterator1(IEnumerator<int> iterator)
        {
            _iterator = iterator;
            moveNextCalled = true;
        }

        public int Peek()
        {
            if (moveNextCalled)
            {
                return _iterator.Current;
            }

            _iterator.MoveNext();
            moveNextCalled = true;
            return _iterator.Current;
        }

        public int Next()
        {
            if (moveNextCalled)
            {
                moveNextCalled = false;
                return _iterator.Current;
            }

            _iterator.MoveNext();
            return _iterator.Current;
        }

        public bool HasNext()
        {
            if (moveNextCalled) return true;

            var result = _iterator.MoveNext();

            if (result)
            {
                moveNextCalled = true;
            }

            return result;
        }
    }
}
