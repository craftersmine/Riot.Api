using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.Summoner;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.League.Matches;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class MatchesApiClientTests
    {
        public const string MyPuuid = "XRWOl9NePvqBbDsCBQKMgks13Cyc5KO1N-ZCPE0xr8Yvt58H7JjiWx_jlkF4VSYc31kBYfoKZtSNhA";
        public const string GameId = "RU_413971566";
        public const int QueueId = 420; // Ranked Solo Queue Summoner Rift

        public RiotLeagueMatchApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new RiotLeagueMatchApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetMatchesForPlayerByPuuidTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            string[] matches =
                await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid, DateTime.Today - TimeSpan.FromDays(1), DateTime.Now, QueueId, LeagueMatchType.Ranked, 1, 5);
            Assert.AreEqual(5, matches.Length, "Length is not 5");
            Assert.IsTrue(matches.Any(), "No matches fetched");
            Assert.IsTrue(matches.Contains(GameId), "No game with ID " + GameId + " found in list");
        }
    }
}
