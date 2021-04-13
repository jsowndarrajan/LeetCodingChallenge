using System.Collections.Generic;
using Shared.Interfaces;

namespace April.Problems
{
    public class NestedIterator : IProblem
    {
        public string Title => "Flatten Nested List Iterator";
        public string Url => "https://leetcode.com/explore/challenge/card/april-leetcoding-challenge-2021/594/week-2-april-8th-april-14th/3706/";

        private readonly Stack<IEnumerator<NestedInteger>> _enumerators;

        public NestedIterator(IList<NestedInteger> nestedList)
        {
            _enumerators = new Stack<IEnumerator<NestedInteger>>();
            var enumerator = nestedList.GetEnumerator();
            _enumerators.Push(enumerator);
        }

        public bool HasNext()
        {
            if (_enumerators.Count == 0) return false;

            var currentEnumerator = _enumerators.Peek();
            if (currentEnumerator.MoveNext())
            {
                if (currentEnumerator.Current.IsInteger()) return true;
                var list = currentEnumerator.Current.GetList();
                if (list?.Count > 0)
                {
                    var enumerator = list.GetEnumerator();
                    _enumerators.Push(enumerator);
                }
                return HasNext();
            }

            if(_enumerators.Count > 0)
                _enumerators.Pop();
            return HasNext();
        }

        public int Next()
        {
            var currentEnumerator = _enumerators.Peek();
            if (currentEnumerator.Current.IsInteger())
            {
                return currentEnumerator.Current.GetInteger();
            }

            var list = currentEnumerator.Current.GetList();
            if (list.Count > 0)
            {
                var enumerator = list.GetEnumerator();
                enumerator.MoveNext();
                _enumerators.Push(enumerator);
            }
            return Next();
        }
    }

    internal interface INestedInteger
    {
        bool IsInteger();
        int GetInteger();
        IList<NestedInteger> GetList();
    }

    public class NestedInteger : INestedInteger
    {
        private readonly int _value;
        private readonly IList<NestedInteger> _nestedIntegers;

        public NestedInteger(IList<NestedInteger> nestedIntegers)
        {
            _nestedIntegers = nestedIntegers;
        }

        public NestedInteger(int value)
        {
            _value = value;
        }

        public bool IsInteger()
        {
            return _nestedIntegers == null;
        }

        public int GetInteger()
        {
            return _value;
        }

        public IList<NestedInteger> GetList()
        {
            return _nestedIntegers;
        }
    }

}
