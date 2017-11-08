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
    }
}
