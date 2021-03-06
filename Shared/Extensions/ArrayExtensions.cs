using System;

namespace Shared.Extensions
{
    public static class ArrayExtensions
    {
        public static T GetRandom<T>(this T[] minimumLengthEncodingDelegates)
        {
            var random = new Random();
            var index = random.Next(0, minimumLengthEncodingDelegates.Length);
            var method = minimumLengthEncodingDelegates[index];
            return method;
        }
    }
}