using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.Summoner;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.League.ChampionRotations;

namespace craftersmine.Riot.Api.Tests.ChampionRotations
{
    [TestClass]
    public class ChampionRotationsApiClientTests
    {
        public const int FirstChampionId = 9;
        public const int FirstChampionIdNewPlayers = 222;
        public const int MaxNewPlayerLevel = 10;

        public LeagueChampionRotationsApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new LeagueChampionRotationsApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetChampionRotationsTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueChampionRotationsInfo rotations = await Client.GetCurrentChampionRotationsForRegionAsync(RiotPlatform.Russia);
            Assert.IsTrue(rotations.FreeChampionIds.Contains(FirstChampionId), "Rotations doesn't have champion " + FirstChampionId + "in rotations");
            Assert.IsTrue(rotations.FreeChampionIdsForNewPlayers.Contains(FirstChampionIdNewPlayers), "Rotations doesn't have champion " + FirstChampionIdNewPlayers + "in rotations for new players");
            Assert.AreEqual(MaxNewPlayerLevel, rotations.MaxNewPlayerLevel, "Max new player level are not equal to " + MaxNewPlayerLevel);
        }
    }
}
