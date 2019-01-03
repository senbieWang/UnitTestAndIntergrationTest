using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

//ºØ≥…≤‚ ‘
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private readonly HttpClient _client;
        public UnitTest1()
        {
            var builder = new WebHostBuilder().UseStartup<WebApplication1.Startup>();
            var testServer = new TestServer(builder);
            _client = testServer.CreateClient();
        }

        [Fact]
        public async Task Test1()
        {
            var result = await _client.GetAsync("/api/values/");
            result.EnsureSuccessStatusCode();

            var data = await result.Content.ReadAsStringAsync();
            Assert.Contains("value1", data);
        }

        [Fact]
        public async Task Test2()
        {
            int id = 1;
            var result = await _client.GetAsync($"/api/values/{id}");
            result.EnsureSuccessStatusCode();

            var data = await result.Content.ReadAsStringAsync();
            Assert.Equal($"value:{id}", data);
        }

    }
}
