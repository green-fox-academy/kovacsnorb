using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Sum;
using NUnit.Framework;

namespace SumTest
{
    [TestFixture]

    public class SumTestCases
    {
        Sum sum = new Sum();

        [Test]
        public void SumTest_WhenList_4_5_6_9_Then24()
        {
            List<int> input = new List<int> { 4, 5, 6, 9 };
            int output = 24;

            Assert.AreEqual(output, sum.SumOfRecords(input));
        }

        [Test]
        public void SumTest_WhenList_4_5_6_9_17_Then41()
        {
            List<int> input = new List<int> { 4, 5, 6, 9, 17 };
            int output = 41;

            Assert.AreEqual(output, sum.SumOfRecords(input));
        }

        [Test]
        public void SumTest_WhenOneElement230_Then230()
        {
            List<int> input = new List<int> { 230 };
            int output = 230;

            Assert.AreEqual(output, sum.SumOfRecords(input));
        }

        [Test]
        public void SumTest_WhenEmptyList_Then0()
        {
            List<int> input = new List<int> { };
            int output = 0;

            Assert.AreEqual(output, sum.SumOfRecords(input));
        }

        [Test]
        public void SumTest_WhenNullList_Then0()
        {
            List<int> input = null;
            int output = 0;

            Assert.AreEqual(output, sum.SumOfRecords(input));
        }
    }
}
