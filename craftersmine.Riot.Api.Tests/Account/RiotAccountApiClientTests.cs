using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Account;
using craftersmine.Riot.Api.Common;

namespace craftersmine.Riot.Api.Tests.Account
{
    [TestClass]
    public class RiotAccountApiClientTests
    {
        public const string MyPuuid = "XRWOl9NePvqBbDsCBQKMgks13Cyc5KO1N-ZCPE0xr8Yvt58H7JjiWx_jlkF4VSYc31kBYfoKZtSNhA";
        public const string MyGameName = "craftersmine";
        public const string MyTagLine = "Ornn";
        public const RiotShards MyShardLor = RiotShards.LoREurope;
        public const RiotShards MyShardValorant = RiotShards.ValorantEurope;

        public TestContext? TestContext { get; set; }

        public string? ApiKey;
        public RiotAccountApiClient? Client;

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new RiotAccountApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey)
                .UseDefaultDataRegion(RiotRegion.Europe).Build());
        }

        [TestMethod]
        public async Task GetAccountByPuuidTest()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            RiotAccount account = await Client.GetAccountByPuuidAsync(MyPuuid);
            Assert.IsNotNull(account);
            Assert.AreEqual(MyPuuid, account.Puuid);
            Assert.AreEqual(MyGameName, account.RiotId);
            Assert.AreEqual(MyTagLine, account.RiotIdTag);
        }

        [TestMethod]
        public async Task GetAccountByRiotIdTest()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            RiotAccount account = await Client.GetAccountByRiotIdAsync(MyGameName, MyTagLine);
            Assert.IsNotNull(account);
            Assert.AreEqual(MyPuuid, account.Puuid);
            Assert.AreEqual(MyGameName, account.RiotId);
            Assert.AreEqual(MyTagLine, account.RiotIdTag);
        }

        [TestMethod]
        public async Task GetActiveShardByPuuidTest()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            RiotActiveShard shard = await Client.GetActiveShardForPlayerByPuuidAsync(RiotShardGame.Valorant, MyPuuid);
            Assert.IsNotNull(shard);
            Assert.AreEqual(shard.ActiveShard, MyShardValorant);
            Assert.AreEqual(shard.Game, RiotShardGame.Valorant);
            Assert.AreEqual(shard.Puuid, MyPuuid);
            shard = await Client.GetActiveShardForPlayerByPuuidAsync(RiotShardGame.LegendsOfRuneterra, MyPuuid);
            Assert.IsNotNull(shard);
            Assert.AreEqual(shard.ActiveShard, MyShardLor);
            Assert.AreEqual(shard.Game, RiotShardGame.LegendsOfRuneterra);
            Assert.AreEqual(shard.Puuid, MyPuuid);
        }
    }
}
