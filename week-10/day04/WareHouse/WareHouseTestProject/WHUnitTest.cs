using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using Xunit;
using WareHouse;


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
        public void Test1()
        {

        }
    }
}
