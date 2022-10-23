using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.SummonerLeagues;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.League.Challenges;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class ChallengesApiTests
    {
        public RiotLeagueChallengesApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new RiotLeagueChallengesApiClient(RiotApiClientSettingsBuilder.CreateSettingsBuilder(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetChallengesTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueChallengeCollection challenges = await Client.GetLeagueChallenges(RiotPlatform.Russia);
        }
    }
}
