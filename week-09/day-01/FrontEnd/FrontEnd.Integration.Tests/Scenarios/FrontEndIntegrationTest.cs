using DemoIntegrationTest.Fixtures;
using FluentAssertions;
using System.Net;
using Xunit;

namespace FrontEnd.Integration.Tests.Scenarios
{
    class FrontEndIntegrationTest
    {
        private readonly TestFixture testFixture;

        public FrontEndIntegrationTest()
        {
            testFixture = new TestFixture();
        }
    }
}
