using RestGrootTest.TestFixture;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace RestGrootTest.Scenarios.Guardian
{
    [Collection("BaseCollection")]
    public class RestGrootShould
    {
        private TestContext TestContext;

        public RestGrootShould(TestContext testContext)
        {
            TestContext = testContext;
        }

        [Fact]
        public async Task ReturnOkStatusIfParameterExists()
        {
            //act
            var response = await TestContext.Client.GetAsync("groot/?someMessage=thisismymessage");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusIfParameterDontExists()
        {
            //act
            var response = await TestContext.Client.GetAsync("groot");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnResponseJsonIfParameterExists()
        {
            //act
            var response = await TestContext.Client.GetAsync("groot?someMessage=thisismymessage");
            var responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"received\":\"thisismymessage\",\"translated\":\"I am Groot!\"}", responseJson);
        }

        [Fact]
        public async Task ReturnResponseJsonIfParameterDontExists()
        {
            //act
            var response = await TestContext.Client.GetAsync("groot?someMessage");
            var responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"error\":\"I am Groot!\"}", responseJson);
        }

    }
}
