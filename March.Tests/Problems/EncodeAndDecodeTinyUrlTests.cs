using System.Collections.Generic;
using March.Problems;
using Moq;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class EncodeAndDecodeTinyUrlTests
    {
        [TestCase("https://leetcode.com/problems/design-tinyurl", "http://tinyurl.com/4e9iAk")]
        public void Encode(string longUrl, string expectedEncodedUrl)
        {
            var mockGenerator = new Mock<IGuidGenerator>();
            mockGenerator.Setup(x => x.Generate()).Returns("4e9iAk");
            var url = new EncodeAndDecodeTinyUrl(new Dictionary<string, string>(),  mockGenerator.Object);
            var actual = url.Encode(longUrl);
            Assert.AreEqual(expectedEncodedUrl, actual);
        }

        [TestCase("http://tinyurl.com/4e9iAk", "https://leetcode.com/problems/design-tinyurl")]
        public void Decode(string shortUrl, string expectedLongUrl)
        {
            var dataStore = new Dictionary<string, string>
            {
                {shortUrl, expectedLongUrl}
            };
            var mockGenerator = new Mock<IGuidGenerator>();
            var url = new EncodeAndDecodeTinyUrl(dataStore, mockGenerator.Object);
            var actual = url.Decode(shortUrl);
            Assert.AreEqual(expectedLongUrl, actual);
        }
    }
}
