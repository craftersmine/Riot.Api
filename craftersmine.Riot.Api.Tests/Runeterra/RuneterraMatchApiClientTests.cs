using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Runeterra.Ranked;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Runeterra.Matches;

namespace craftersmine.Riot.Api.Tests.Runeterra
{
    [TestClass]
    public class RuneterraMatchApiClientTests
    {
        public const string Puuid = "XRWOl9NePvqBbDsCBQKMgks13Cyc5KO1N-ZCPE0xr8Yvt58H7JjiWx_jlkF4VSYc31kBYfoKZtSNhA";
        public const RiotRegion Region = RiotRegion.Europe;
        public readonly Guid MatchId = new Guid("0d5e1659-1c63-4658-8abd-81c086dd62ed");

        public const int OrderOfPlay = 0;
        public const int TotalTurnCount = 21;
        public const string GameVersion = "live_2_4_18";
        public const string DeckCode = "CMAAEBYBAEDRMGREFYZDKCABAABQMCYSCQNB2JYCAQAQABYMFIWAMAIBBEKCAIRHFE";
        public const string DeckFaction1 = "faction_Demacia_Name";
        public const string DeckFaction2 = "faction_Freljord_Name";
        public const RuneterraGameOutcome GameOutcome = RuneterraGameOutcome.Loss;
        public const RuneterraGameMode GameMode = RuneterraGameMode.Constructed;
        public const RuneterraGameType GameType = RuneterraGameType.AI;
        public readonly DateTime GameStartTime = new DateTime(2021, 03, 26, 05, 52, 02);
        public readonly Guid DeckId = new Guid("7c487324-cdec-44c6-b0a3-cb21853c1879");

        public RuneterraMatchesApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new RuneterraMatchesApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetMatchesByPuuidTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            string[] matches = await Client.GetMatchesByPuuidAsync(Region, Puuid);
            Assert.IsTrue(matches.Contains(MatchId.ToString()), "No match with specified ID found");
        }

        [TestMethod]
        public async Task GetMatchByIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            RuneterraMatch match = await Client.GetMatchByIdAsync(Region, MatchId);
            Assert.AreEqual(MatchId, match.Metadata.MatchId);
            Assert.IsTrue(match.Metadata.Participants.Contains(Puuid));
            Assert.AreEqual(2, match.Metadata.DataVersion);

            Assert.AreEqual(TotalTurnCount, match.Info.TotalTurnCount);
            Assert.AreEqual(GameVersion, match.Info.GameVersion);
            Assert.AreEqual(GameType, match.Info.GameType);
            Assert.AreEqual(GameMode, match.Info.GameMode);
            Assert.IsTrue(match.Info.GameStartTime >= GameStartTime);

            RuneterraMatchPlayer? player = match.Info.Players.FirstOrDefault(p => p.Puuid == Puuid);
            Assert.AreEqual(Puuid, player.Puuid);
            Assert.AreEqual(OrderOfPlay, player.OrderOfPlay);
            Assert.AreEqual(GameOutcome, player.GameOutcome);
            Assert.AreEqual(DeckCode, player.DeckCode);
            Assert.AreEqual(DeckId, player.DeckId);
            Assert.IsTrue(player.Factions.Contains(DeckFaction1));
            Assert.IsTrue(player.Factions.Contains(DeckFaction2));
        }
    }
}
