using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Yondu;

namespace YonduTestProject
{
    public class YonduTest
    {
        private readonly TestServer server;
        private readonly HttpClient client;

        public YonduTest()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await client.GetAsync("yondu?distance=100&time=10");
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"distance\":100.0,\"time\":10.0,\"speed\":10.0}", json);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnBadRequestStatus()
        {
            var response = await client.GetAsync("yondu?distance=100");
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"error\":\"Error occured!\"}", json);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

    }
}
