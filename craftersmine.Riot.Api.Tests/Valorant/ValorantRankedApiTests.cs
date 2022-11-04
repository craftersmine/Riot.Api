using craftersmine.Riot.Api.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Valorant.Ranked;

namespace craftersmine.Riot.Api.Tests.Valorant
{
    [TestClass]
    public class ValorantRankedApiTests
    {
        public const int TotalPlayers = 15000;
        public const int ImmortalStartingPage = 2;
        public const int ImmortalStartingIndex = 224;
        public const int TopTierRRThreshold = 550;
        public const int TierId = 25;
        public const int TierRatingThreshold = 100;
        public const int TierStartingPage = 19;
        public const int TierStartingIndex = 3644;
        public const int PlayerLeaderboardRank = 1;
        public const int PlayerRankedRating = 942;
        public const int PLayerNumberOfWins = 69;
        public const int PlayerCompetitiveTier = 27;
        public const string PlayerPuuid = "f3YUCjZUZYgK9_rpfHbjQv98gm6jHzSNQopHKgDcvBs-JgWnrXv28qAQBmarC3pw5sx3a6m1umwTjw";
        public const string PlayerGameName = "LFT nataNk1wnl";
        public const string PlayerTagLine = "1wnl";
        public const RiotShards Region = RiotShards.ValorantEurope;
        public readonly Guid ActId = new Guid("aca29595-40e4-01f5-3f35-b1b3d304c96e");

        public ValorantRankedApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new ValorantRankedApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetLeaderboardByActIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            ValorantLeaderboard leaderboard = await Client.GetLeaderboardByActIdAsync(Region, ActId);
            Assert.AreEqual(ActId, leaderboard.ActId);
            Assert.AreEqual(Region, leaderboard.Shard);
            Assert.AreEqual(TotalPlayers, leaderboard.TotalPlayers);
            Assert.AreEqual(ImmortalStartingPage, leaderboard.ImmortalStartingPage);
            Assert.AreEqual(ImmortalStartingIndex, leaderboard.ImmortalStartingIndex);
            Assert.AreEqual(TopTierRRThreshold, leaderboard.TopTierRRThreshold);
            Assert.AreEqual(0, leaderboard.StartIndex);
            Assert.AreEqual("", leaderboard.Query);

            Assert.IsTrue(leaderboard.TierDetails.ContainsKey(TierId));
            ValorantTierDetails? tierDetails = leaderboard.TierDetails[TierId];
            Assert.AreEqual(TierRatingThreshold, tierDetails.RankedRatingThreshold);
            Assert.AreEqual(TierStartingPage, tierDetails.StartingPage);
            Assert.AreEqual(TierStartingIndex, tierDetails.StartingIndex);

            ValorantPlayer? player = leaderboard.Players.FirstOrDefault(p => p.Puuid == PlayerPuuid);
            Assert.IsNotNull(player);
            Assert.AreEqual(PlayerPuuid, player.Puuid);
            Assert.AreEqual(PlayerGameName, player.GameName);
            Assert.AreEqual(PlayerTagLine, player.TagLine);
            Assert.AreEqual(PLayerNumberOfWins, player.NumberOfWins);
            Assert.AreEqual(PlayerCompetitiveTier, player.CompetitiveTier);
            Assert.AreEqual(PlayerLeaderboardRank, player.LeaderboardRank);
            Assert.AreEqual(PlayerRankedRating, player.RankedRating);
        }
    }
}
