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
    public class RestGreetingShould
    {
        TestContext testContext;

        public RestGreetingShould(TestContext testContext)
        {
            this.testContext = testContext;
        }

        [Fact]
        public async Task ReturnStatusOK()
        {
            //act
            var response = await testContext.Client.GetAsync("/greeter?name=Petike&title=student");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnStatusOKWhenParameterMissing()
        {
            //act
            var response = await testContext.Client.GetAsync("/greeter");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnResponseJsonWhenParametersAreGiven()
        {
            //act
            var response = await testContext.Client.GetAsync("/greeter?name=Sanyi&title=rocker");
            var responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"welcome_message\":\"Oh, hi there Sanyi, my dear rocker!\"}", responseJson);
        }

        [Fact]
        public async Task ReturnResponseJsonWhenParametersAreNotOk()
        {
            //act
            var response = await testContext.Client.GetAsync("/greeter?name=Sanyi");
            var responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"error\":\"Please provide a title!\"}", responseJson);
        }
    }
}
