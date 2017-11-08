using RestExcercise.Models;
using System;
using Xunit;

namespace RestExerciseTest
{
    public class DoublingShould
    {
        [Fact]
        public void ReturnZeroWhenEmpty()
        {
            // arrange
            var doUntil = new DoUntil();

            // act

            // assert
            Assert.Equal(0, doUntil.Until);
        }
    }
}
