using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RestExerciseTest.TextFixture
{
    [CollectionDefinition ("BaseCollection")]
    public class Collection : ICollectionFixture<TestContext>
    {
    }
}
