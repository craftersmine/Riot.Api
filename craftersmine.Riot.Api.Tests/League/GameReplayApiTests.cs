using craftersmine.Riot.Api.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.League.Client.Replay;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class GameReplayApiTests
    {
        public LeagueReplayApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new LeagueReplayApiClient(RiotApiClientSettingsBuilder.CreateSettingsBuilder(ApiKey).IgnoreSSLCertificates().Build());
        }

        [TestMethod]
        public async Task GetGameInfoTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");

            LeagueGameInfo gameInfo = await Client.GetGameInfoAsync();
        }
    }
}
