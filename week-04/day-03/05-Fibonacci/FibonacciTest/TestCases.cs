using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_Fibonacci;
using NUnit.Framework;

namespace FibonacciTest
{
    [TestFixture]
    public class TestCases
    {
        Fibonacci fibonacci = new Fibonacci();

        [Test]
        public void TestFibonacci_When11_Then55()
        {
            int input = 11;
            int output = 55;
            Assert.AreEqual(output, fibonacci.FibonacciCalculator(input));
        }

        [Test]
        public void TestFibonacci_When1_Then0()
        {
            int input = 1;
            int output = 0;
            Assert.AreEqual(output, fibonacci.FibonacciCalculator(input));
        }

        [Test]
        public void TestFibonacci_When2_Then1()
        {
            int input = 2;
            int output = 1;
            Assert.AreEqual(output, fibonacci.FibonacciCalculator(input));
        }

        [Test]
        public void TestFibonacci_When3_Then1()
        {
            int input = 3;
            int output = 1;
            Assert.AreEqual(output, fibonacci.FibonacciCalculator(input));
        }

        [Test]
        public void TestFibonacci_When4_Then2()
        {
            int input = 4;
            int output = 2;
            Assert.AreEqual(output, fibonacci.FibonacciCalculator(input));
        }

        [Test]
        public void TestFibonacci_WhenMinus5_ThenMinus1()
        {
            int input = -5;
            int output = -1;
            Assert.AreEqual(output, fibonacci.FibonacciCalculator(input));
        }
    }
}
