using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Anagram;
using NUnit.Framework;

namespace AnagramTest
{
    [TestFixture]

    public class AnagramTestCases
    {
        Anagram anagram = new Anagram();

        [Test]
        public void TestAnagram_WhenAlmafaFlaama_ThenTrue()
        {
            string input1 = "almafa";
            string input2 = "flaama";
            bool output = true;

            Assert.AreEqual(output, anagram.IsAnagram(input1, input2));
        }

        [Test]
        public void TestAnagram_WhenAlmafaAlmafaaaaa_ThenFalse()
        {
            string input1 = "almafa";
            string input2 = "almafaaaaa";
            bool output = false;

            Assert.AreEqual(output, anagram.IsAnagram(input1, input2));
        }

        [Test]
        public void TestAnagram_WhenAlmafaAlmaba_ThenFalse()
        {
            string input1 = "almafa";
            string input2 = "almaba";
            bool output = false;

            Assert.AreEqual(output, anagram.IsAnagram(input1, input2));
        }
    }

}
