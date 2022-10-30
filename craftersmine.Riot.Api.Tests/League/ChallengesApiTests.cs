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
        public const int SelectedTitleIdInClient = 20100304;
        public const LeagueChallengeLevel TotalLevel = LeagueChallengeLevel.Gold;
        public const LeagueChallengeLevel CollectionLevel = LeagueChallengeLevel.Platinum;
        public const LeagueChallengeLevel OldFriendChallengeLevel = LeagueChallengeLevel.Challenger;

        public LeagueChallengesApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new LeagueChallengesApiClient(RiotApiClientSettingsBuilder.CreateSettingsBuilder(ApiKey).Build());
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
            Assert.IsTrue(challengesAreHere.Bronze > 0.44, "\"Challenges Are Here\" challenge bronze percentiles are less than 0.45");
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
                    LeagueChallengeLevel.Challenger, OldFriendId);
            Assert.IsTrue(challengeLeaderboard.Any(), "No leaderboards for \"Old friends\" were fetched");
            //LeagueChallengeLeaderboardEntry entry = challengeLeaderboard[MyPuuid];
            //Assert.IsNotNull(entry, "No leaderboards entry found for specified PUUID");
            //Assert.IsTrue(entry.Value > 790, "Value for challenge is less than 790");
            //Assert.IsTrue(entry.Position > 13, "Position in leaderboard is less than 13");
        }

        [TestMethod]
        public async Task GetChallengePercentilesByIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueChallengePercentiles challengePercentiles =
                await Client.GetLeagueChallengePercentilesByChallengeIdAsync(RiotPlatform.Russia, OldFriendId);
            Assert.IsTrue(challengePercentiles.None >= 0.90);
            Assert.IsTrue(challengePercentiles.Iron >= 0.2);
            Assert.IsTrue(challengePercentiles.Bronze >= 0.16);
            Assert.IsTrue(challengePercentiles.Silver >= 0.12);
            Assert.IsTrue(challengePercentiles.Gold >= 0.1);
            Assert.IsTrue(challengePercentiles.Platinum >= 0.07);
            Assert.IsTrue(challengePercentiles.Diamond >= 0.05);
            Assert.IsTrue(challengePercentiles.Master >= 0.03);
            Assert.IsTrue(challengePercentiles.Grandmaster >= 0.005);
            Assert.IsTrue(challengePercentiles.Challenger >= 0.001);
        }

        [TestMethod]
        public async Task GetPlayerChallengesInfoByPuuidTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueChallengesPlayerData challengesPlayerData = await Client.GetLeagueChallengesForPlayerByPuuid(RiotPlatform.Russia, MyPuuid);
            Assert.IsTrue(challengesPlayerData.TotalPoints.CurrentValue > 6800, "Current total value is less than 6800");
            Assert.AreEqual(28780, challengesPlayerData.TotalPoints.MaxValue, "Max value for total stats is not equal to 28780");
            Assert.AreEqual(TotalLevel, challengesPlayerData.TotalPoints.Level, "Total level is not equals to " + TotalLevel.GetStringFor());
            Assert.IsTrue(challengesPlayerData.TotalPoints.Percentile >= 0.100);
            
            Assert.IsTrue(challengesPlayerData.CategoryPoints.Collection.CurrentValue > 1200, "Collection current value is less than 1200");
            Assert.AreEqual(4200, challengesPlayerData.CategoryPoints.Collection.MaxValue, "Collection max value is not equals to 4200");
            Assert.AreEqual(CollectionLevel, challengesPlayerData.CategoryPoints.Collection.Level,
                "Collection level is not " + CollectionLevel.GetStringFor());
            Assert.IsTrue(challengesPlayerData.CategoryPoints.Collection.Percentile >= 0.086, "Collection percentile is less than 0.086");

            LeaguePlayerChallengeInfo oldFriendsChallengeInfo = challengesPlayerData.Challenges[OldFriendId];
            Assert.IsNotNull(oldFriendsChallengeInfo, "No \"Old friends\" challenge data fetched");
            Assert.AreEqual(OldFriendId, oldFriendsChallengeInfo.ChallengeId, "\"Old friends\" ID is not " + OldFriendId);
            Assert.IsTrue(oldFriendsChallengeInfo.AchievedAt >= new DateTime(2022, 6, 28), "\"Old friends\" achieved date is less than 28 jun. 2022");
            Assert.AreEqual(OldFriendChallengeLevel, oldFriendsChallengeInfo.Level, "\"Old friends\" level is not " + OldFriendChallengeLevel.GetStringFor());
            Assert.IsTrue(oldFriendsChallengeInfo.Percentile >= 0.0, "\"Old friends\" percentile is less than 0.171");
            Assert.IsTrue(oldFriendsChallengeInfo.Value >= 7.0, "\"Old friends\" current value is less than 7.0");
            Assert.IsTrue(oldFriendsChallengeInfo.PlayersInLevel >= 3000, "Players in level " + OldFriendChallengeLevel.GetStringFor() + " of challenge \"Old friends\" is less than 15000");
            Assert.IsTrue(oldFriendsChallengeInfo.Position >= 10,
                "Player position in " + OldFriendChallengeLevel.GetStringFor() +
                " of challenge \"Old friends\" is less than 10");

            LeagueChallengesPlayerClientPreferences clientPreferences = challengesPlayerData.ClientPreferences;
            Assert.IsTrue(string.IsNullOrWhiteSpace(clientPreferences.BannerAccent), "Banner accent value in client is not empty");
            Assert.AreEqual(SelectedTitleIdInClient, clientPreferences.TitleId, "Title ID is not for \"Unkillable Demon\"");
            Assert.IsTrue(clientPreferences.ChallengeTokensIds.Contains(OldFriendId), "Selected challenge tokens does not contain \"Old friends\" token");
        }
    }
}
