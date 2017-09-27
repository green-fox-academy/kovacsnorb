using _06_Extension;
using NUnit.Framework;
using System.Collections.Generic;

namespace ExtensionTest
{
    [TestFixture]
    public class ExtensionCases
    {
        Extension extension = new Extension();

        [Test]
        public void TestAdd_2and3is5()
        {
            Assert.AreEqual(6, extension.Add(3, 3));
        }

        [Test]
        public void TestAdd_1and4is5()
        {
            Assert.AreEqual(9, extension.Add(1, 8));
        }

        [Test]
        public void TestMaxOfThree_First()
        {
            Assert.AreEqual(7, extension.MaxOfThree(5, 4, 7));
        }

        [Test]
        public void TestMaxOfThree_Fhird()
        {
            Assert.AreEqual(4, extension.MaxOfThree(3, 4, 2));
        }

        [Test]
        public void TestMedian_Four()
        {
            Assert.AreEqual(5, extension.Median(new List<int>() { 7, 3, 5, 5 }));
        }

        [Test]
        public void TestMedian_Five()
        {
            Assert.AreEqual(3, extension.Median(new List<int>() { 1, 3, 2, 4, 5 }));
        }

        [Test]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('A'));
        }

        [Test]
        public void TestIsVowel_u()
        {
            Assert.True(extension.IsVowel('U'));
        }

        [Test]
        public void testTranslate_bemutatkozik()
        {
            Assert.AreEqual("bevemuvutavatkovozevek", extension.Translate("bemutatkozek"));
        }

        [Test]
        public void testTranslate_kolbice()
        {
            Assert.AreEqual("lavagavapuvus", extension.Translate("lagapus"));
        }
    }
}