using Groot;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace GrootIntegrationTests
{
    public class GuardianTests
    {
        private HttpClient Client;
        private TestServer Server;

        public GuardianTests()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/groot");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task IndexShouldReturnOkStatusWithMessage()
        {
            var response = await Client.GetAsync("/groot?message=somemessage");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
