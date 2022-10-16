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
            SummonerLeague[] myLeagues = await Client.GetLeagueEntriesForSummonerById(RiotPlatform.Russia, MySummonerId);
            Assert.IsTrue(myLeagues.Length > 0, "No leagues has loaded for summoner ID");
            Assert.AreEqual(MySummonerId, myLeagues[0].SummonerId, "Summoner ID is not same");
            Assert.AreEqual(MySummonerNameRu, myLeagues[0].SummonerName, "Summoner Name is not same");
            Assert.AreEqual(MySummonerId, myLeagues[1].SummonerId, "Summoner ID is not same");
            Assert.AreEqual(MySummonerNameRu, myLeagues[1].SummonerName, "Summoner Name is not same");
        }
    }
}
