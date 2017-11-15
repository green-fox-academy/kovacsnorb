using Newtonsoft.Json;
using RestPractice.Models;
using RestPracticeIntegrationTest.TestFixture;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RestPracticeIntegrationTest.Scenarios.Home
{
    [Collection ("BaseCollection")]
    public class RestDoUntilShould
    {
        TestContext testContext;

        public RestDoUntilShould(TestContext testContext)
        {
            this.testContext = testContext;
        }

        [Fact]
        public async Task ReturnStatusOkWhenWhatIsFilled()
        {
            //act
            var response = await testContext.Client.GetAsync("dountil/factor");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnResponseJsonWhenAllParametersAreFilled()
        {
            var jsonObject = new DoUntilObj
            {
                until = 5,
            };

            var convertedjsonObject = JsonConvert.SerializeObject(jsonObject);

            var content = new StringContent(convertedjsonObject.ToString(),
                         encoding: Encoding.UTF8,
                         mediaType: "application/json");

            var response = await testContext.Client.PostAsync("/dountil/factor", content);
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"result\":120}", responseJson);
        }

        [Fact]
        public async Task ReturnResponseJsonWhenAllParametersAreFilledSum()
        {
            var jsonObject = new DoUntilObj
            {
                until = 10,
            };

            var convertedjsonObject = JsonConvert.SerializeObject(jsonObject);

            var content = new StringContent(convertedjsonObject.ToString(),
                         encoding: Encoding.UTF8,
                         mediaType: "application/json");

            var response = await testContext.Client.PostAsync("/dountil/sum", content);
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"result\":55}", responseJson);
        }

        [Fact]
        public async Task ReturnResponseJsonWhenWhatParametersIsMissing()
        {
            var jsonObject = new DoUntilObj
            {
                until = 10,
            };

            var convertedjsonObject = JsonConvert.SerializeObject(jsonObject);

            var content = new StringContent(convertedjsonObject.ToString(),
                         encoding: Encoding.UTF8,
                         mediaType: "application/json");

            var response = await testContext.Client.PostAsync("/dountil", content);
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide an operation!\"}", responseJson);
        }

        [Fact]
        public async Task ReturnResponseJsonWhenNumbersAreMissing()
        {
            var jsonObject = new DoUntilObj
            {
            };

            var convertedjsonObject = JsonConvert.SerializeObject(jsonObject);

            var content = new StringContent(convertedjsonObject.ToString(),
                         encoding: Encoding.UTF8,
                         mediaType: "application/json");

            var response = await testContext.Client.PostAsync("/dountil/sum", content);
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide a number!\"}", responseJson);
        }
    }
}
