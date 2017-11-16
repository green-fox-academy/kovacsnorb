using RestGrootTest.TestFixture;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RestGrootTest.Scenarios.Guardian
{
    [Collection("BaseCollection")]
    public class RestArrowShould
    {
        private TestContext TestContext;

        public RestArrowShould(TestContext testContext)
        {
            TestContext = testContext;
        }

        [Fact]
        public async Task ReturnOkStatusWhenParametersAreGiven()
        {
            //act
            var response = await TestContext.Client.GetAsync("yondu/?distance=34.5&time=6.9");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusWhenParametersAreNotGiven()
        {
            //act
            var response = await TestContext.Client.GetAsync("yondu");

            //assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task ReturnResponseJsonWhenParametersAreOk()
        {
            //act
            var response = await TestContext.Client.GetAsync("yondu/?distance=10.5&time=2.4");
            var responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"distance\":10.5,\"time\":2.4,\"speed\":4.375}", responseJson);
        }

        [Fact]
        public async Task ReturnResponseJsonWhenTimeIsZero()
        {
            //act
            var response = await TestContext.Client.GetAsync("yondu/?distance=10.5&time=0");
            var responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"error\":\"I am Groot!\"}", responseJson);
        }

        [Fact]
        public async Task ReturnResponseJsonWhenParametersMissing()
        {
            //act
            var response = await TestContext.Client.GetAsync("yondu");
            var responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"error\":\"I am Groot!\"}", responseJson);
        }
    }
}
