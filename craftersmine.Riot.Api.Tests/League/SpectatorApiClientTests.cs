using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.Spectator;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class SpectatorApiClientTests
    {
        
        public RiotLeagueSpectatorApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new RiotLeagueSpectatorApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetFeaturedGamesTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueCurrentFeaturedGamesInformation featuredGamesInformation = await Client.GetCurrentFeaturedGames(RiotPlatform.Russia);
            
        }
    }
}
