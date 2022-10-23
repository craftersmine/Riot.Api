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
        public const string MyPuuid = "XRWOl9NePvqBbDsCBQKMgks13Cyc5KO1N-ZCPE0xr8Yvt58H7JjiWx_jlkF4VSYc31kBYfoKZtSNhA";
        public const int ChallengesAreHereId = 600012;
        public const int OldFriendId = 501004;

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
            Assert.IsTrue(challenges.Any(), "No challenges data fetched");
            Assert.IsNotNull(challenges.FirstOrDefault(c => c.Id == 0), "No challenge with ID 0");
            Assert.IsNotNull(challenges.FirstOrDefault(c => c.Id == ChallengesAreHereId), "No \"Challenges are here!\" challenge fetched!");
        }

        [TestMethod]
        public async Task GetChallengePercentilesTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueChallengePercentilesCollection challenges = await Client.GetLeagueChallengePercentilesAsync(RiotPlatform.Russia);
            Assert.IsTrue(challenges.Any(), "No challenges percentile data fetched");
            LeagueChallengePercentiles challengesAreHere = challenges.FirstOrDefault(c => c.Key == ChallengesAreHereId).Value;
            Assert.IsNotNull(challengesAreHere, "No \"Challenges are here!\" challenge percentiles fetched!");
            Assert.IsTrue(challengesAreHere.Bronze > 0.45, "\"Challenges Are Here\" challenge bronze percentiles are less than 0.45");
        }

        [TestMethod]
        public async Task GetChallengeByIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueChallenge crystalChallenge = await Client.GetLeagueChallengeByIdAsync(RiotPlatform.Russia, 0);
            Assert.AreEqual(0, crystalChallenge.Id, "\"Crystal\" ID is not same");
            Assert.AreEqual(LeagueChallengeState.Enabled, crystalChallenge.State, "\"Crystal\" state is not Enabled");
            Assert.AreEqual(LeagueChallengeTrackingState.Unknown, crystalChallenge.Tracking, "\"Crystal\" is differs from unknown tracking state");
            Assert.AreEqual(0, crystalChallenge.Thresholds.Iron, 0.0001, "\"Crystal\" bronze threshold is not 0");
            Assert.AreEqual(750, crystalChallenge.Thresholds.Bronze, 0.0001, "\"Crystal\" bronze threshold is not 0");
            Assert.IsTrue(crystalChallenge.IsLeaderboardEnabled, "\"Crystal\" leaderboard is disabled");
            Assert.IsNotNull(crystalChallenge.LocalizedNames["en-US"], "\"Crystal\" English (United States) locale is missing");
            Assert.IsNotNull(crystalChallenge.LocalizedNames["ru-RU"], "\"Crystal\" Russian locale is missing");

            LeagueChallenge challengesAreHere = await Client.GetLeagueChallengeByIdAsync(RiotPlatform.Russia, 600012);
            Assert.AreEqual(ChallengesAreHereId, challengesAreHere.Id, "\"Challenges Are Here\" ID is not same");
            Assert.IsTrue(challengesAreHere.EndTimestamp > new DateTime(2022, 10, 9), "\"Challenges Are Here\" end timestamp is less than 10 Oct. 2022");
            Assert.AreEqual(LeagueChallengeState.Enabled, challengesAreHere.State, "\"Challenges Are Here\" state is not Enabled");
            Assert.AreEqual(LeagueChallengeTrackingState.Unknown, challengesAreHere.Tracking, "\"Challenges Are Here\" is differs from unknown tracking state");
            Assert.AreEqual(0, challengesAreHere.Thresholds.Bronze, 0.0001, "\"Challenges Are Here\" bronze threshold is not 0");
            Assert.IsFalse(challengesAreHere.IsLeaderboardEnabled, "\"Challenges Are Here\" leaderboard is enabled");
            Assert.IsNotNull(challengesAreHere.LocalizedNames["en-US"], "\"Challenges Are Here\" English (United States) locale is missing");
            Assert.IsNotNull(challengesAreHere.LocalizedNames["ru-RU"], "\"Challenges Are Here\" Russian locale is missing");
        }

        [TestMethod]
        public async Task GetChallengeLeaderboardByIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueChallengeLeaderboardEntryCollection challengeLeaderboard =
                await Client.GetLeagueChallengeLeaderboardByChallengeIdAsync(RiotPlatform.Russia,
                    LeagueChallengeLevel.Grandmaster, OldFriendId, 15);
            Assert.IsTrue(challengeLeaderboard.Any(), "No leaderboards for \"Old friends\" were fetched");
            LeagueChallengeLeaderboardEntry entry = challengeLeaderboard[MyPuuid];
            Assert.IsNotNull(entry, "No leaderboards entry found for specified PUUID");
            Assert.IsTrue(entry.Value > 790, "Value for challenge is less than 790");
            Assert.IsTrue(entry.Position > 13, "Position in leaderboard is less than 13");
        }

        [TestMethod]
        public async Task GetChallengePercentilesByIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueChallengePercentiles challengePercentiles =
                await Client.GetLeagueChallengePercentilesByChallengeIdAsync(RiotPlatform.Russia, OldFriendId);
            Assert.IsTrue(challengePercentiles.None >= 0.99);
            Assert.IsTrue(challengePercentiles.Iron >= 0.235);
            Assert.IsTrue(challengePercentiles.Bronze >= 0.188);
            Assert.IsTrue(challengePercentiles.Silver >= 0.160);
            Assert.IsTrue(challengePercentiles.Gold >= 0.126);
            Assert.IsTrue(challengePercentiles.Platinum >= 0.085);
            Assert.IsTrue(challengePercentiles.Diamond >= 0.066);
            Assert.IsTrue(challengePercentiles.Master >= 0.045);
            Assert.IsTrue(challengePercentiles.Grandmaster >= 0.012);
            Assert.IsTrue(challengePercentiles.Challenger >= 0.0025);
        }
    }
}
