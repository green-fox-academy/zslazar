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

        //With giving a parameter the status is ok
        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/groot");

            //assert
            //Assert.Equal(HttpStatusCode.Ok, response.StatusCode);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        //the given respone is the same as expected
        [Fact]
        public async Task IndexShouldReturnOkStatusWithMessage()
        {
            var response = await Client.GetAsync("/groot?message=somemessage");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        //Without giving a parameter the status is not ok
        [Fact]
        public async Task IndexShouldReturnNotOkStatus()
        {
            var response = await Client.GetAsync("/groot");

            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"error\":\"I am Groot!\"}", json);
        }

        //and the given error response is the same as expected
        [Fact]
        public async Task IndexShouldReturnNotOkStatusWithMessage()
        {
            var response = await Client.GetAsync("/groot?message=somemessage");

            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"received\":\"somemessage\",\"translated\":\"I am Groot!\"}", json);
        }

    }
}
