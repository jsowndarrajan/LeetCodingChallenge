using Shared.Interfaces;
using System;
using System.Collections.Generic;

namespace March.Problems
{
    public class EncodeAndDecodeTinyUrl : IProblem
    {
        public string Title => "Encode and Decode TinyURL";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/590/week-3-march-15th-march-21st/3673/";

        private readonly Dictionary<string, string> _dataStore;
        private readonly IGuidGenerator _guidGenerator;

        public EncodeAndDecodeTinyUrl(Dictionary<string, string> dataStore, IGuidGenerator guidGenerator)
        {
            _dataStore = dataStore;
            _guidGenerator = guidGenerator;
        }

        public EncodeAndDecodeTinyUrl()
        {
            _dataStore = new Dictionary<string, string>();
            _guidGenerator = new GuidGenerator();
        }

        public string Encode(string longUrl)
        {
            var encodedUrl = $"http://tinyurl.com/{_guidGenerator.Generate()}";
            _dataStore.Add(encodedUrl, longUrl);
            return encodedUrl;
        }

        public string Decode(string shortUrl)
        {
            return _dataStore.ContainsKey(shortUrl) ? _dataStore[shortUrl] : string.Empty;
        }

    }

    public interface IGuidGenerator
    {
        string Generate();
    }

    public class GuidGenerator : IGuidGenerator
    {
        public string Generate()
        {
            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, 7);
        }
    }
}
