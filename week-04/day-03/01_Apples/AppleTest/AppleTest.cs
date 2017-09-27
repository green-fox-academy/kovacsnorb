using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Apples;

namespace ApplesTest
{
    [TestFixture]

    public class AppleTest
    {
        Apple apple = new Apple();

        [Test]
        public void TestApple_WhenApple_ThenApple()
        {
            string output = "apple";
            Assert.AreEqual(output, apple.GetApple());
        }

        [Test]
        public void TestApple_WhenApples_ThenFailedTest()
        {
            string output = "apples";
            Assert.AreEqual(output, apple.GetApple());
        }
    }
}
