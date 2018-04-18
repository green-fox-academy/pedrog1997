using Groot.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Groot.IntegrationTests
{
    public class GuardianTests
    {
        private HttpClient client;
        private TestServer server;

        public GuardianTests()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            var response = await client.GetAsync("/");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Groot_WithParameter_Ok()
        {
            var response = await client.GetAsync("/groot?message=ehesvagyok");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Groot_CheckResponse()
        {
            var response = await client.GetAsync("/groot?message=nagyonehesvagyok");

            var GrootResponseObject = new GrootResponse
            {
                Received = "nagyonehesvagyok",
                Translated = "I am Groot!"
            };

            Assert.Equal(JsonConvert.SerializeObject(GrootResponseObject).ToLower(), response.Content.ReadAsStringAsync().Result.ToLower());
        }

        [Fact]
        public async Task Groot_WoithoutParameter()
        {
            var response = await client.GetAsync("/groot");

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task Groot_CheckResponseWithoutParameter()
        {
            var response = await client.GetAsync("/groot");
            var error = new ErrorMessage()
            {
                Error = "I am Groot!"
            };
            Assert.Equal(JsonConvert.SerializeObject(error), response.Content.ReadAsStringAsync().Result);
        }
    }
}
