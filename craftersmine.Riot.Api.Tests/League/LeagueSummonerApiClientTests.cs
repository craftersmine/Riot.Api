using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.Summoner;
using craftersmine.Riot.Api.Tests.Account;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class LeagueSummonerApiClientTests
    {
        public const string MySummonerNameRu = "craftersmine";
        public const string MyAccountId = "1Qr4Eh3voM158K6jQOrEkl02Tk20MY9HI3NLq6phi4NG7sjvo1OeYhzy";
        public const string MySummonerId = "PtRpTVHs2N12hcdRB5OgxNcs2y4wAK7yg4K38y8028YwBGw";

        public RiotLeagueSummonerApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new RiotLeagueSummonerApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetSummonerBySummonerNameTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            LeagueSummoner summoner = await Client.GetSummonerByNameAsync(RiotPlatform.Russia, MySummonerNameRu);
            Assert.IsNotNull(summoner);
            Assert.AreEqual(MySummonerNameRu, summoner.Name);
            Assert.AreEqual(RiotAccountApiClientTests.MyPuuid, summoner.RiotPuuid);
            Assert.AreEqual(MyAccountId, summoner.AccountId);
            Assert.AreEqual(MySummonerId, summoner.Id);
        }

        [TestMethod]
        public async Task GetSummonerByRiotPuuidTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            LeagueSummoner summoner =
                await Client.GetSummonerByPuuidAsync(RiotPlatform.Russia, RiotAccountApiClientTests.MyPuuid);
            Assert.IsNotNull(summoner);
            Assert.AreEqual(RiotAccountApiClientTests.MyPuuid, summoner.RiotPuuid);
            Assert.AreEqual(MySummonerNameRu, summoner.Name);
            Assert.AreEqual(MyAccountId, summoner.AccountId);
            Assert.AreEqual(MySummonerId, summoner.Id);
        }

        [TestMethod]
        public async Task GetSummonerByAccountIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            LeagueSummoner summoner =
                await Client.GetSummonerByAccountIdAsync(RiotPlatform.Russia, MyAccountId);
            Assert.IsNotNull(summoner);
            Assert.AreEqual(RiotAccountApiClientTests.MyPuuid, summoner.RiotPuuid);
            Assert.AreEqual(MySummonerNameRu, summoner.Name);
            Assert.AreEqual(MyAccountId, summoner.AccountId);
            Assert.AreEqual(MySummonerId, summoner.Id);
        }

        [TestMethod]
        public async Task GetSummonerByIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            LeagueSummoner summoner =
                await Client.GetSummonerByIdAsync(RiotPlatform.Russia, MySummonerId);
            Assert.IsNotNull(summoner);
            Assert.AreEqual(RiotAccountApiClientTests.MyPuuid, summoner.RiotPuuid);
            Assert.AreEqual(MySummonerNameRu, summoner.Name);
            Assert.AreEqual(MyAccountId, summoner.AccountId);
            Assert.AreEqual(MySummonerId, summoner.Id);
        }
    }
}
