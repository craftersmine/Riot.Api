using craftersmine.Riot.Api.League.Summoner;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.SummonerLeagues;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class SummonerLeaguesApiClientTests
    {
        public const string MySummonerNameRu = "craftersmine";
        public const string MyAccountId = "1Qr4Eh3voM158K6jQOrEkl02Tk20MY9HI3NLq6phi4NG7sjvo1OeYhzy";
        public const string MySummonerId = "PtRpTVHs2N12hcdRB5OgxNcs2y4wAK7yg4K38y8028YwBGw";

        public const string ChallengerRuQueueName = "Nautilus's Shadows";
        public const string ChallengerRuLeagueId = "408239d1-7786-3057-ac0e-2f651eff19bd";
        public const string GrandmasterRuQueueName = "Katarina's Elite";
        public const string GrandmasterRuLeagueId = "18bf0d20-1875-3c47-8204-c812de8ea994";
        public const string MasterRuQueueName = "Riven's Villains";
        public const string MasterRuLeagueId = "2f6f1cc0-7b00-3d3c-80d6-721c4ff004b0";

        public const string GoldSoloRuLeagueId = "ec505230-5223-463c-a25b-0025d31da466";
        public const string GoldSoloRuLeagueName = "Nidalee's Agents";

        public RiotSummonerLeaguesApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new RiotSummonerLeaguesApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetLeagueEntriesForSummonerByIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            SummonerLeague[] myLeagues = await Client.GetLeagueEntriesForSummonerByIdAsync(RiotPlatform.Russia, MySummonerId);
            Assert.IsTrue(myLeagues.Length > 0, "No leagues has loaded for summoner ID");
            Assert.AreEqual(MySummonerId, myLeagues[0].SummonerId, "Summoner ID is not same");
            Assert.AreEqual(MySummonerNameRu, myLeagues[0].SummonerName, "Summoner Name is not same");
            Assert.AreEqual(MySummonerId, myLeagues[1].SummonerId, "Summoner ID is not same");
            Assert.AreEqual(MySummonerNameRu, myLeagues[1].SummonerName, "Summoner Name is not same");
        }

        [TestMethod]
        public async Task GetChallengerLeaguesByQueueTests()
        {
            Assert.IsNotNull(Client, "Client not initialized!");
            LeagueList challengerLeagues =
                await Client.GetChallengerLeaguesByQueueAsync(RiotPlatform.Russia, LeagueQueueType.RankedSoloDuo);
            Assert.AreEqual(ChallengerRuQueueName, challengerLeagues.Name, "Name is not the same as " + ChallengerRuQueueName);
            Assert.AreEqual(ChallengerRuLeagueId, challengerLeagues.Id, "ID is not the same as " + ChallengerRuLeagueId);
            Assert.AreEqual(LeagueRankedTier.Challenger, challengerLeagues.Tier, "Tier is not Challenger");
            Assert.AreEqual(LeagueQueueType.RankedSoloDuo, challengerLeagues.Queue, "Queue is not Ranked Solo/Duo");
        }

        [TestMethod]
        public async Task GetGrandmasterLeaguesByQueueTests()
        {
            Assert.IsNotNull(Client, "Client not initialized!");
            LeagueList grandmasterLeagues =
                await Client.GetGrandmasterLeaguesByQueueAsync(RiotPlatform.Russia, LeagueQueueType.RankedSoloDuo);
            Assert.AreEqual(GrandmasterRuQueueName, grandmasterLeagues.Name, "Name is not the same as " + GrandmasterRuQueueName);
            Assert.AreEqual(GrandmasterRuLeagueId, grandmasterLeagues.Id, "ID is not the same as " + GrandmasterRuLeagueId);
            Assert.AreEqual(LeagueRankedTier.Grandmaster, grandmasterLeagues.Tier, "Tier is not Grandmaster");
            Assert.AreEqual(LeagueQueueType.RankedSoloDuo, grandmasterLeagues.Queue, "Queue is not Ranked Solo/Duo");
        }
        
        [TestMethod]
        public async Task GetMasterLeaguesByQueueTests()
        {
            Assert.IsNotNull(Client, "Client not initialized!");
            LeagueList masterLeagues =
                await Client.GetMasterLeaguesByQueueAsync(RiotPlatform.Russia, LeagueQueueType.RankedSoloDuo);
            Assert.AreEqual(MasterRuQueueName, masterLeagues.Name, "Name is not the same as " + MasterRuQueueName);
            Assert.AreEqual(MasterRuLeagueId, masterLeagues.Id, "ID is not the same as " + MasterRuLeagueId);
            Assert.AreEqual(LeagueRankedTier.Master, masterLeagues.Tier, "Tier is not Master");
            Assert.AreEqual(LeagueQueueType.RankedSoloDuo, masterLeagues.Queue, "Queue is not Ranked Solo/Duo");
        }

        [TestMethod]
        public async Task GetLeagueEntriesTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            SummonerLeague[] leaguesGoldIII = await Client.GetLeagueEntriesAsync(RiotPlatform.Russia,
                LeagueQueueType.RankedSoloDuo, LeagueRankedTier.Gold, LeagueDivisionRank.III, 1);
            SummonerLeague[] leagueGoldIIIfpage = await Client.GetLeagueEntriesAsync(RiotPlatform.Russia,
                LeagueQueueType.RankedSoloDuo, LeagueRankedTier.Gold, LeagueDivisionRank.III);
            Assert.AreEqual(leagueGoldIIIfpage[0].DivisionRank, leaguesGoldIII[0].DivisionRank, "Division ranks are not equal");
            Assert.AreEqual(leagueGoldIIIfpage[0].Id, leaguesGoldIII[0].Id, "League IDs are not equal");
            Assert.AreEqual(leagueGoldIIIfpage[0].Tier, leaguesGoldIII[0].Tier, "League tiers are not equal");
        }

        [TestMethod]
        public async Task GetLeagueEntriesByLeagueIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueList goldLeagueSolo = await Client.GetLeagueEntriesByLeagueIdAsync(RiotPlatform.Russia, GoldSoloRuLeagueId);
            Assert.AreEqual(GoldSoloRuLeagueId, goldLeagueSolo.Id, "League ID is mismatched");
            Assert.AreEqual(LeagueRankedTier.Gold, goldLeagueSolo.Tier, "Tier is mismatched");
            Assert.AreEqual(GoldSoloRuLeagueName, goldLeagueSolo.Name, "Names are mismatched");
            Assert.AreEqual(LeagueQueueType.RankedSoloDuo, goldLeagueSolo.Queue, "Queue types are mismatched");
        }
    }
}
