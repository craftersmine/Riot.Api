using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.Client;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class GameClientApiClientTests
    {
        public LeagueGameClientApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new LeagueGameClientApiClient(RiotApiClientSettingsBuilder.CreateSettingsBuilder(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetAllGameDataTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueGameData gameData = await Client.GetAllGameDataAsync();
        }
    }
}
