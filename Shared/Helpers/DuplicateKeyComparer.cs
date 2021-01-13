using System;
using System.Collections.Generic;

namespace Shared.Helpers
{
    public class DuplicateKeyComparer<TKey>: IComparer<TKey> where TKey : IComparable
    {
        public int Compare(TKey x, TKey y)
        {
            return x.CompareTo(y) == 0 ? 1 : x.CompareTo(y);
        }
    }
}