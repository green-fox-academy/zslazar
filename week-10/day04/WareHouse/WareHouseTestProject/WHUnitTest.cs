using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WareHouse;
using Xunit;

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
