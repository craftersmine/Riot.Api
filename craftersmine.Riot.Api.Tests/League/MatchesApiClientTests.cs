using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.Summoner;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.League.Matches;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class MatchesApiClientTests
    {
        public const string MyPuuid = "XRWOl9NePvqBbDsCBQKMgks13Cyc5KO1N-ZCPE0xr8Yvt58H7JjiWx_jlkF4VSYc31kBYfoKZtSNhA";

        public const string MyEuPuuid =
            "n6r5fAuMxbY5fdDs-DulcDfg81DuaTi2vjjSXIlE3b2j0BRl3UOalqO-pMFy7GcX9vaCR-6pU-zOcg";
        public const string GameId = "RU_415270624";
        public const string GameEuId = "EUN1_3231727530";
        public const string GameMode = "CLASSIC";
        public const long GameIdLong = 415270624;
        public const long GameEuIdLong = 3231727530;
        public const int QueueId = 420; // Ranked Solo Queue Summoner Rift
        public const int MapId = 11;
        public const LeagueMatchType MatchType = LeagueMatchType.Ranked;

        public LeagueMatchApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new LeagueMatchApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetMatchesForPlayerByPuuidTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            string[] matches =
                await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid, DateTime.Today - TimeSpan.FromDays(1), DateTime.Now, QueueId, MatchType, 1, 5);
            Assert.AreEqual(5, matches.Length, "Length is not 5");
            Assert.IsTrue(matches.Any(), "No matches fetched");
            Assert.IsTrue(matches.Contains(GameId), "No game with ID " + GameId + " found in list");

            string[] matches1 = await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid,
                DateTime.Today - TimeSpan.FromDays(1), DateTime.Now, QueueId, MatchType);
            Assert.IsTrue(matches1.Any(), "No matches fetched");
            Assert.IsTrue(matches1.Contains(GameId), "No game with ID " + GameId + " found in list");

            string[] matches2 = await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid, QueueId, MatchType);
            Assert.IsTrue(matches2.Any(), "No matches fetched");
            Assert.IsTrue(matches2.Contains(GameId), "No game with ID " + GameId + " found in list");

            string[] matches3 = await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid, QueueId);
            Assert.IsTrue(matches3.Any(), "No matches fetched");
            if (MatchType == LeagueMatchType.Ranked)
            {
                Assert.IsTrue(matches3.Contains(GameId), "No game with ID " + GameId + " found in list");
            }
            
            string[] matches4 = await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid, MatchType);
            Assert.IsTrue(matches4.Any(), "No matches fetched");
            Assert.IsTrue(matches4.Contains(GameId), "No game with ID " + GameId + " found in list");

            string[] matches5 =
                await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid, DateTime.Today - TimeSpan.FromDays(1), DateTime.Now);
            Assert.IsTrue(matches5.Any(), "No matches fetched");
            if (MatchType == LeagueMatchType.Ranked)
            {
                Assert.IsTrue(matches5.Contains(GameId), "No game with ID " + GameId + " found in list");
            }

            string[] matches6 =
                await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid, DateTime.Today - TimeSpan.FromDays(1), DateTime.Now, QueueId);
            Assert.IsTrue(matches6.Any(), "No matches fetched");
            if (MatchType == LeagueMatchType.Ranked)
            {
                Assert.IsTrue(matches6.Contains(GameId), "No game with ID " + GameId + " found in list");
            }
            
            
            string[] matches7 =
                await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid, DateTime.Today - TimeSpan.FromDays(1), DateTime.Now, MatchType);
            Assert.IsTrue(matches7.Any(), "No matches fetched");
            Assert.IsTrue(matches7.Contains(GameId), "No game with ID " + GameId + " found in list");
        }

        [TestMethod]
        public async Task GetMatchInfoByMatchIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            LeagueMatch match = await Client.GetMatchByIdAsync(RiotRegion.Europe, GameId);
            Assert.AreEqual(GameIdLong, match.Info.GameId, "Game ID is not equal");
            Assert.IsTrue(match.Info.GameVersion.Major == 12 && match.Info.GameVersion.Minor == 20, "Game patch version is not 12.20");
            Assert.AreEqual(GameMode, match.Info.GameMode, "Game mode is not " + GameMode);
            Assert.AreEqual(MapId, match.Info.MapId, "Map ID is not " + MapId);
            Assert.AreEqual(10, match.Info.Participants.Length, "Participants count is not 10");
            Assert.AreEqual(2, match.Metadata.DataVersion, "Data version for match is not 2");
            Assert.AreEqual(10, match.Metadata.Participants.Length, "Match participants count is not 10");
            Assert.AreEqual(GameId, match.Metadata.MatchId, "Match ID is not the same as " + GameId);
            Assert.IsTrue(match.Metadata.Participants.Contains(MyPuuid), "Participants doesn't have " + MyPuuid);

            
            LeagueMatch match1 = await Client.GetMatchByIdAsync(RiotRegion.Europe, GameEuId);
            Assert.AreEqual(GameEuIdLong, match1.Info.GameId, "Game ID is not equal");
            Assert.IsTrue(match1.Info.GameVersion.Major == 12 && match1.Info.GameVersion.Minor == 19, "Game patch version is not 12.20");
            Assert.AreEqual(GameMode, match1.Info.GameMode, "Game mode is not " + GameMode);
            Assert.AreEqual(MapId, match1.Info.MapId, "Map ID is not " + MapId);
            Assert.AreEqual(10, match1.Info.Participants.Length, "Participants count is not 10");
            Assert.AreEqual(2, match1.Metadata.DataVersion, "Data version for match is not 2");
            Assert.AreEqual(10, match1.Metadata.Participants.Length, "Match participants count is not 10");
            Assert.AreEqual(GameEuId, match1.Metadata.MatchId, "Match ID is not the same as " + GameEuId);
            Assert.IsTrue(match1.Metadata.Participants.Contains(MyEuPuuid), "Participants doesn't have " + MyEuPuuid);
        }
    }
}
