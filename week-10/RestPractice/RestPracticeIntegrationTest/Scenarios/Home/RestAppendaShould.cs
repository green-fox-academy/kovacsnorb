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
    public class RestAppendaShould
    {
        TestContext testContext;

        public RestAppendaShould(TestContext testContext)
        {
            this.testContext = testContext;
        }

        [Fact]
        public async Task ReturnStatusOKWhenParameterIsOk()
        {
            //act
            var response = await testContext.Client.GetAsync("/appenda/kuty");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnStatusNotFoundWhenParameterIsNotOk()
        {
            //act
            var response = await testContext.Client.GetAsync("/appenda");

            //assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task ReturnResponseJsonWhenParameterIsOK()
        {
            //act
            var response = await testContext.Client.GetAsync("/appenda/macsk");
            var responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"appended\":\"macska\"}", responseJson);
        }
    }
}
