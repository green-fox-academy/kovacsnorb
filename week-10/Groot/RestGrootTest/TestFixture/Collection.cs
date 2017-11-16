using Xunit;

namespace RestGrootTest.TestFixture
{
    [CollectionDefinition("BaseCollection")]
    public class Collection : ICollectionFixture<TestContext>
    {
    }
}
