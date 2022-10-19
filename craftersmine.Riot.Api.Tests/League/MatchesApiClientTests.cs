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
        public const string GameId = "RU_413971566";
        public const string GameMode = "CLASSIC";
        public const long GameIdLong = 413971566;
        public const int QueueId = 420; // Ranked Solo Queue Summoner Rift
        public const int MapId = 11;

        public RiotLeagueMatchApiClient? Client { get; set; }
        public string? ApiKey { get; set; }
        public string? ParticipantFilePath { get; private set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            ParticipantFilePath = TestContext?.Properties["ParticipantFilePath"]?.ToString();
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

            string[] matches1 = await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid,
                DateTime.Today - TimeSpan.FromDays(1), DateTime.Now, QueueId, LeagueMatchType.Ranked);
            Assert.AreEqual(20, matches1.Length, "Length is not 20");
            Assert.IsTrue(matches1.Any(), "No matches fetched");
            Assert.IsTrue(matches1.Contains(GameId), "No game with ID " + GameId + " found in list");

            string[] matches2 = await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid, QueueId, LeagueMatchType.Ranked);
            Assert.AreEqual(20, matches2.Length, "Length is not 20");
            Assert.IsTrue(matches2.Any(), "No matches fetched");
            Assert.IsTrue(matches2.Contains(GameId), "No game with ID " + GameId + " found in list");

            string[] matches3 = await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid, QueueId);
            Assert.AreEqual(20, matches3.Length, "Length is not 20");
            Assert.IsTrue(matches3.Any(), "No matches fetched");
            Assert.IsTrue(matches3.Contains(GameId), "No game with ID " + GameId + " found in list");
            
            string[] matches4 = await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid, LeagueMatchType.Ranked);
            Assert.AreEqual(20, matches4.Length, "Length is not 20");
            Assert.IsTrue(matches4.Any(), "No matches fetched");
            Assert.IsTrue(matches4.Contains(GameId), "No game with ID " + GameId + " found in list");

            string[] matches5 =
                await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid, DateTime.Today - TimeSpan.FromDays(1), DateTime.Now);
            Assert.AreEqual(20, matches5.Length, "Length is not 5");
            Assert.IsTrue(matches5.Any(), "No matches fetched");
            Assert.IsTrue(matches5.Contains(GameId), "No game with ID " + GameId + " found in list");
            
            string[] matches6 =
                await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid, DateTime.Today - TimeSpan.FromDays(1), DateTime.Now, QueueId);
            Assert.AreEqual(20, matches6.Length, "Length is not 5");
            Assert.IsTrue(matches6.Any(), "No matches fetched");
            Assert.IsTrue(matches6.Contains(GameId), "No game with ID " + GameId + " found in list");
            
            string[] matches7 =
                await Client.GetMatchesForPlayerByPuuidAsync(RiotRegion.Europe, MyPuuid, DateTime.Today - TimeSpan.FromDays(1), DateTime.Now, LeagueMatchType.Ranked);
            Assert.AreEqual(20, matches7.Length, "Length is not 5");
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
        }
    }
}
