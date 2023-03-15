using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.Matches;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common.Exceptions;
using craftersmine.Riot.Api.Status;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class StatusApiClientTests
    {
        public const RiotPlatform LeagueRegion = RiotPlatform.Russia;
        public const RiotShards ValorantShard = RiotShards.ValorantEurope;
        public const RiotShards LoRShard = RiotShards.LoREurope;

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
            try
            {
                RiotServiceStatus leagueStatus = await Client.GetLeagueStatusForRegionAsync(LeagueRegion);
                RiotServiceStatus valorantStatus = await Client.GetValorantStatusForRegionAsync(ValorantShard);
                RiotServiceStatus loRStatus = await Client.GetLoRStatusForRegionAsync(LoRShard);
            }
            catch (RiotApiException e)
            {
                if (e.ResponseCode == HttpResponseCode.ServiceUnavailable)
                    Assert.Inconclusive("Riot Service Status API returned code 503 - Service Unavailable. Try again");
                else throw;
            }
        }
    }
}
