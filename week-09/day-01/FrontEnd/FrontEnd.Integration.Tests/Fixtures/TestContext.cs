using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace FrontEnd.Integration.Tests.Fixtures
{
    class TestContext
    {
        private TestServer testServer;

        public HttpClient Client { get; set; }

        public TestContext(WebHostBuilder builder)
        {
            testServer = new TestServer(builder);
            Client = testServer.CreateClient();
        }
    }
}
