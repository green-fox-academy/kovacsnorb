using RestPracticeIntegrationTest.TestFixture;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RestPracticeIntegrationTest.Scenarios.Home
{
    [Collection ("BaseCollection")]
    public class RestDoublingShould
    {
        private TestContext TestContext;

        public RestDoublingShould(TestContext testContext)
        {
            TestContext = testContext;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            //act
            var response = await TestContext.Client.GetAsync("/doubling?input=10");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
