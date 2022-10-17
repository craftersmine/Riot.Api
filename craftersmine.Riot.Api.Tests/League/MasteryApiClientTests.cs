using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.Summoner;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.League.Mastery;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class MasteryApiClientTests
    {
        public const int OrnnChampionId = 516;
        public const int VolibearChampionId = 106;
        public const int GnarChampionId = 150;
        public const bool EnableExperimental = false;

        public RiotLeagueMasteryApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            if (EnableExperimental)
                Client = new RiotLeagueMasteryApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).UseExperimentalLeaguesApi().Build());
            else 
                Client = new RiotLeagueMasteryApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetMasteriesBySummonerIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueChampionMastery[] masteries =
                await Client.GetMasteriesBySummonerId(RiotPlatform.Russia, LeagueSummonerApiClientTests.MySummonerId);
            Assert.IsTrue(masteries.Any(), "No masteries returned");
            LeagueChampionMastery? ornnMastery = masteries.FirstOrDefault(m => m.ChampionId == OrnnChampionId);
            Assert.IsNotNull(ornnMastery,
                "No mastery for Ornn in my champion pool (almost a 1m points and mastery 7, something wrong)");
            Assert.IsTrue(ornnMastery.MasteryLevel == 7,
                "Got 7th mastery, but it reported " + ornnMastery.MasteryLevel);
            Assert.IsTrue(ornnMastery.MasteryPoints > 950000, "It is definitely over 950k");
        }

        [TestMethod]
        public async Task GetMasteryForChampionBySummonerIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueChampionMastery ornnMastery =
                await Client.GetMasteryForChampionBySummonerId(RiotPlatform.Russia, OrnnChampionId,
                    LeagueSummonerApiClientTests.MySummonerId);
            Assert.IsNotNull(ornnMastery,
                "No mastery for Ornn in my champion pool (almost a 1m points and mastery 7, something wrong)");
            Assert.IsTrue(ornnMastery.MasteryLevel == 7,
                "Got 7th mastery, but it reported " + ornnMastery.MasteryLevel);
            Assert.IsTrue(ornnMastery.MasteryPoints > 950000, "It is definitely over 950k");
        }

        [TestMethod]
        public async Task GetTopMasteryBySummonerIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueChampionMastery[] topMasteries =
                await Client.GetTopThreeMasteriesBySummonerId(RiotPlatform.Russia,
                    LeagueSummonerApiClientTests.MySummonerId);
            Assert.IsTrue(topMasteries.Any(), "No masteries returned");
            LeagueChampionMastery? ornnMastery = topMasteries.FirstOrDefault(m => m.ChampionId == OrnnChampionId);
            LeagueChampionMastery? voliMastery = topMasteries.FirstOrDefault(m => m.ChampionId == VolibearChampionId);
            LeagueChampionMastery? gnarMastery = topMasteries.FirstOrDefault(m => m.ChampionId == GnarChampionId);
            Assert.IsNotNull(ornnMastery,
                "No mastery for Ornn in my champion pool (almost a 1m points and mastery 7, something wrong)");
            Assert.IsNotNull(voliMastery,
                "No mastery for Volibear in my champion pool (over 150k points and mastery 7, something wrong)");
            Assert.IsNotNull(gnarMastery,
                "No mastery for Gnar in my champion pool (over 35k points and mastery 5, something wrong)");
            Assert.IsTrue(ornnMastery.MasteryLevel == 7,
                "Got 7th mastery on Ornn, but it reported " + ornnMastery.MasteryLevel);
            Assert.IsTrue(ornnMastery.MasteryPoints > 950000, "It is definitely over 950k on Ornn");
            Assert.IsTrue(voliMastery.MasteryLevel == 7,
                "Got 7th mastery on Volibear, but it reported " + voliMastery.MasteryLevel);
            Assert.IsTrue(voliMastery.MasteryPoints > 150000, "It is definitely over 150k on Volibear");
            Assert.IsTrue(gnarMastery.MasteryLevel == 5,
                "Got 5th mastery on Gnar, but it reported " + gnarMastery.MasteryLevel);
            Assert.IsTrue(gnarMastery.MasteryPoints > 35000, "It is definitely over 35k on Gnar");
        }

        [TestMethod]
        public async Task GetTotalMasteriesBySummonerIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            int totalMasteries =
                await Client.GetTotalMasteriesBySummonerId(RiotPlatform.Russia,
                    LeagueSummonerApiClientTests.MySummonerId);
        }
    }
}