using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.Matches;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.League.Status;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class StatusApiClientTests
    {
        public const RiotPlatform Region = RiotPlatform.EuropeNordicEast;

        public RiotServiceStatusApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new RiotServiceStatusApiClient(RiotApiClientSettingsBuilder.CreateSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetServerStatus()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            RiotServiceStatus status = await Client.GetLeagueStatusForRegionAsync(Region);
        }
    }
}
