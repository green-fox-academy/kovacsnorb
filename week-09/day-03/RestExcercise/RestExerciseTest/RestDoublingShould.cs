using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using RestExcercise;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xunit;

namespace RestExerciseTest
{
    public class RestDoublingShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestDoublingShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public void ReturnOkStatus()
        {
            Assert.True(true);
        }
    }
}
