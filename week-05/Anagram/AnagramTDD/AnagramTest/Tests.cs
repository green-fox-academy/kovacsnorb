using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnagramTDD;
using NUnit.Framework;

namespace AnagramTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestAnagram_SameWords()
        {
            string input1 = "alma";
            string input2 = "alma";

            Assert.AreEqual(true, Anagram.IsAnagram(input1, input2));

            input1 = "korte";
            input2 = "korte";

            Assert.AreEqual(true, Anagram.IsAnagram(input1, input2));
        }

        [Test]
        public void TestAnagram_DifferentWords()
        {
            string input1 = "alma";
            string input2 = "korte";

            Assert.AreEqual(false, Anagram.IsAnagram(input1, input2));

            input1 = "alma";
            input2 = "malna";

            Assert.AreEqual(false, Anagram.IsAnagram(input1, input2));

            input1 = "korte";
            input2 = "malna";

            Assert.AreEqual(false, Anagram.IsAnagram(input1, input2));
        }

        [Test]
        public void TestAnagram_SameWordsUpperLowerCase()
        {
            string input1 = "alma";
            string input2 = "ALMA";

            Assert.AreEqual(true, Anagram.IsAnagram(input1, input2));

            input1 = "ALMA";
            input2 = "alma";

            Assert.AreEqual(true, Anagram.IsAnagram(input1, input2));

        }
        [Test]
        public void TestAnagram_SameCharacter()
        {
            string input1 = "alma";
            string input2 = "mala";

            Assert.AreEqual(true, Anagram.IsAnagram(input1, input2));

        }
        [Test]
        public void TestAnagram_WithEmptyString()
        {
            string input1 = String.Empty;
            string input2 = "mala";

            Assert.AreEqual(false, Anagram.IsAnagram(input1, input2));

        }
        [Test]
        public void TestAnagram_WithWhiteSpace()
        {
            string input1 = "alma";
            string input2 = "al ma";

            Assert.AreEqual(true, Anagram.IsAnagram(input1, input2));
        }
    }
}
