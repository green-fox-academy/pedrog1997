using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace YondusArrow.IntegrationTests
{
    public class YonduControllerTests
    {
        HttpClient client;
        TestServer server;

        public YonduControllerTests()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Fact]
        public async Task Yondu_ReturnOK()
        {
            var response = await client.GetAsync("/yondu?distance=100&time=10");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
