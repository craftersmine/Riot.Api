using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Runeterra.Ranked;

namespace craftersmine.Riot.Api.Tests.Runeterra
{
    [TestClass]
    public class RuneterraRankedApiClientTests
    {
        public const string TopPlayerName = "LFR Shunpo";
        public const RiotShards Region = RiotShards.LoREurope;
        
        public RuneterraRankedApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new RuneterraRankedApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetLeaderboardsTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            RuneterraPlayer[] leaderboard = await Client.GetLeaderboardAsync(Region);
            RuneterraPlayer? top = leaderboard.FirstOrDefault(p => p.Rank == 0);
            Assert.AreEqual(0, top.Rank);
            Assert.IsTrue(top.LeaguePoints >= 1600);
            Assert.AreEqual(TopPlayerName, top.Name);
        }
    }
}
