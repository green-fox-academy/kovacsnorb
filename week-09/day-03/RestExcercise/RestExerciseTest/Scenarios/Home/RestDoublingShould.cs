using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using RestExcercise;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RestExerciseTest
{
    [Collection("BaseCollection")]
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
            // act
            var response = await TestContext.Client.GetAsync("/doubling?input=5");
            //string responseJson = await response.Content.ReadAsStringAsync();

            // asster
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusForNoInput()
        {
            // act
            var response = await TestContext.Client.GetAsync("/doubling");

            // asster
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnResponseJson()
        {
            // act
            var response = await TestContext.Client.GetAsync("/doubling?input=5");
            string responseJson = await response.Content.ReadAsStringAsync();

            // asster
            Assert.Equal("{\"received\":5,\"result\":10}", responseJson);
        }

        [Fact]
        public async Task ReturnResponseJsonForNoInput()
        {
            // act
            var response = await TestContext.Client.GetAsync("/doubling?input");
            string responseJson = await response.Content.ReadAsStringAsync();

            // asster
            Assert.Equal("{\"error\":\"Please provide an input!\"}", responseJson);
        }
    }
}
