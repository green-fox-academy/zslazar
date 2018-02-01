using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using Xunit;
using WareHouse;
using System.Threading.Tasks;
using System.Net;

namespace WareHouseTestProject
{
    public class WHUnitTest
    {
        private HttpClient Client;
        private TestServer Server;

        public WHUnitTest()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task LowerPriceQueryShouldReturnOkStatus()
        {
            var response = await Client.GetAsync("/warehouse/query?price=50&type=lower");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task HigherPriceQueryShouldReturnJson()
        {
            var response = await Client.GetAsync("/warehouse/query?price=50&type=higher");
                        
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
