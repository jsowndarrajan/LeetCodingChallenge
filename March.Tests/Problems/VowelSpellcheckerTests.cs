using March.Problems;
using NUnit.Framework;

namespace March.Tests.Problems
{
    public class VowelSpellcheckerTests
    {
        [TestCase(new[] { "KiTe", "kite", "hare", "Hare" },
            new[] { "kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto" },
            new[] { "kite", "KiTe", "KiTe", "Hare", "hare", "", "", "KiTe", "", "KiTe" })]
        public void Spellchecker(string[] wordList, string[] queries, string[] expected)
        {
            var sut = new VowelSpellchecker();
            var actual = sut.Spellchecker(wordList, queries);
            Assert.AreEqual(expected, actual);
        }
    }
}
