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

        [Fact]
        public async Task ReturnNotOkStatus()
        {
            //act
            var response = await TestContext.Client.GetAsync("/doubling");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnResponseJsonIfInputIsAdded()
        {
            //act
            var response = await TestContext.Client.GetAsync("/doubling?input=13");
            var responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"received\":13,\"result\":26}", responseJson);
        }

        [Fact]
        public async Task ReturnResponseJsonIfInfutIsMissing()
        {
            //act
            var response = await TestContext.Client.GetAsync("/doubling?input");
            var responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"error\":\"Please provide an input!\"}", responseJson);
        }
    }
}
