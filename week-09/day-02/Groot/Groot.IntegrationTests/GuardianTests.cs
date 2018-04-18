using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
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
    }
}
