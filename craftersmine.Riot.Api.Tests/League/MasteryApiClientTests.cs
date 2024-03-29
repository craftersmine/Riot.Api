﻿using craftersmine.Riot.Api.Common;
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
        public const int ZiggsChampionId = 115;
        public const bool EnableExperimental = false;

        public LeagueMasteryApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            
            // Client is created differently depending whether experimental features are enabled or not
#pragma warning disable CS0162 // Code is heuristically unreachable
            if (EnableExperimental)
                Client = new LeagueMasteryApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).UseExperimentalLeaguesApi().Build());
            else 
                Client = new LeagueMasteryApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
#pragma warning restore CS0162 // Code is heuristically unreachable
        }

        [TestMethod]
        public async Task GetMasteriesByPuuidTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueChampionMastery[] masteries =
                await Client.GetMasteriesByPuuid(RiotPlatform.Russia, LeagueSummonerApiClientTests.MyPuuid);
            Assert.IsTrue(masteries.Any(), "No masteries returned");
            LeagueChampionMastery? ornnMastery = masteries.FirstOrDefault(m => m.ChampionId == OrnnChampionId);
            Assert.IsNotNull(ornnMastery,
                "No mastery for Ornn in my champion pool (almost a 1m points and mastery 7, something wrong)");
            Assert.IsTrue(ornnMastery.MasteryLevel == 7,
                "Got 7th mastery, but it reported " + ornnMastery.MasteryLevel);
            Assert.IsTrue(ornnMastery.MasteryPoints > 950000, "It is definitely over 950k");
        }

        [TestMethod]
        public async Task GetMasteryForChampionByPuuidTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueChampionMastery ornnMastery =
                await Client.GetMasteryForChampionByPuuid(RiotPlatform.Russia, OrnnChampionId,
                    LeagueSummonerApiClientTests.MyPuuid);
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
                await Client.GetTopThreeMasteriesByPuuid(RiotPlatform.Russia,
                    LeagueSummonerApiClientTests.MyPuuid);
            Assert.IsTrue(topMasteries.Any(), "No masteries returned");
            LeagueChampionMastery? ornnMastery = topMasteries.FirstOrDefault(m => m.ChampionId == OrnnChampionId);
            LeagueChampionMastery? voliMastery = topMasteries.FirstOrDefault(m => m.ChampionId == VolibearChampionId);
            LeagueChampionMastery? gnarMastery = topMasteries.FirstOrDefault(m => m.ChampionId == ZiggsChampionId);
            Assert.IsNotNull(ornnMastery,
                "No mastery for Ornn in my champion pool (almost a 1m points and mastery 7, something wrong)");
            Assert.IsNotNull(voliMastery,
                "No mastery for Volibear in my champion pool (over 150k points and mastery 7, something wrong)");
            Assert.IsNotNull(gnarMastery,
                "No mastery for Ziggs in my champion pool (over 35k points and mastery 5, something wrong)");
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
        public async Task GetTotalMasteriesByPuuidTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            int totalMasteries =
                await Client.GetTotalMasteriesByPuuid(RiotPlatform.Russia,
                    LeagueSummonerApiClientTests.MyPuuid);
        }
    }
}