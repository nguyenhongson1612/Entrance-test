using Task1_String_Length_Frequency;

namespace StringLengthFrequencyTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestCase1()
        {
            var strings = new List<string> { "a", "ab", "abc", "cd", "def", "gh" };
            var expected = new List<string> { "ab", "cd", "gh" };
            var result = Program.MostFrequentStringLengths(strings);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCase2()
        {
            var strings = new List<string> { "hello", "world", "c#", "python", "java" };
            var expected = new List<string> { "hello", "world" };
            var result = Program.MostFrequentStringLengths(strings);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCase3()
        {
            var strings = new List<string> { "x", "yy", "zzz", "ww", "mmm" };
            var expected = new List<string> { "yy", "ww" };
            var result = Program.MostFrequentStringLengths(strings);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestEmptyList()
        {
            var strings = new List<string>();
            var expected = new List<string>();
            var result = Program.MostFrequentStringLengths(strings);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSingleString()
        {
            var strings = new List<string> { "abcdef" };
            var expected = new List<string> { "abcdef" };
            var result = Program.MostFrequentStringLengths(strings);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
