using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CountLetters;
using NUnit.Framework;

namespace TestCountLetters
{
    [TestFixture]

    public class TestCases
    {
        CountLetters countLetters = new CountLetters();

        [Test]
        public void CountLettersTest_WithWordAlmafa()
        {
            string input = "almafa";
            Dictionary<char, int> output = new Dictionary<char, int>
            {
                { 'a', 3 },
                { 'f', 1 },
                { 'l', 1 },
                { 'm', 1 }
            };
            Assert.AreEqual(output, countLetters.LetterCounter(input));
        }
    }
}
