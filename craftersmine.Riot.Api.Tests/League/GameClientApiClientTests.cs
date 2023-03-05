using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.Client;
using craftersmine.Riot.Api.League.Matches;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class GameClientApiClientTests
    {
        public LeagueGameClientApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new LeagueGameClientApiClient(RiotApiClientSettingsBuilder.CreateSettingsBuilder(ApiKey).IgnoreSSLCertificates().Build());
        }

        [TestMethod]
        public async Task GetAllGameDataTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueGameData gameData = await Client.GetAllGameDataAsync();

            Assert.AreEqual("CLASSIC", gameData.GameData.GameMode);
            Assert.AreEqual("Map11", gameData.GameData.MapName);
            Assert.AreEqual("Chemtech", gameData.GameData.MapTerrain);
            Assert.AreEqual(11, gameData.GameData.MapId);
            Assert.IsTrue(gameData.GameData.GameTime > TimeSpan.FromSeconds(0));

            Assert.IsTrue(string.IsNullOrWhiteSpace(gameData.ActivePlayer.SummonerName));

            LeaguePlayerData player = gameData.Players.First(p => p.SummonerName == "craftersmine");
            Assert.AreEqual("Орн", player.ChampionName);
            Assert.IsFalse(player.IsBot);
            Assert.IsFalse(player.IsDead);
            Assert.AreEqual(16, player.ChampionLevel);
            Assert.AreEqual("game_character_displayname_Ornn", player.RawChampionName);
            Assert.AreEqual("game_character_skin_displayname_Ornn_5", player.RawSkinName);
            Assert.AreEqual(TimeSpan.FromSeconds(0), player.RespawnTimer);
            Assert.AreEqual(LeagueMatchPosition.Top, player.Position);
            Assert.AreEqual(8437, player.Runes.Keystone.Id);
            Assert.AreEqual(5, player.Scores.Kills);
            Assert.AreEqual(3, player.Scores.Deaths);
            Assert.AreEqual(13, player.Scores.Assists);
            Assert.AreEqual(170, player.Scores.CreepScore);
            Assert.IsTrue(player.Scores.VisionScore > 31);
            Assert.AreEqual(5, player.SkinId);
            Assert.AreEqual("Дух леса Орн", player.SkinName);
            Assert.AreEqual("GeneratedTip_SummonerSpell_S12_SummonerTeleportUpgrade_DisplayName", player.SummonerSpells.SpellOne.RawDisplayName);
            Assert.AreEqual(LeagueTeam.Chaos, player.Team);

            GameStartEvent evt1 = gameData.Events[0] as GameStartEvent;
            Assert.IsNotNull(evt1);
            Assert.AreEqual(0, evt1.EventId);
            Assert.AreEqual(LeagueGameEventType.GameStart, evt1.EventType);
            Assert.IsTrue(evt1.EventTime > TimeSpan.FromSeconds(0));

            ChampionKilledEvent evt2 = gameData.Events.GetEvent(2) as ChampionKilledEvent;
            Assert.IsNotNull(evt2);
            Assert.AreEqual(2, evt2.EventId);
            Assert.AreEqual(LeagueGameEventType.ChampionKill, evt2.EventType);
            Assert.IsTrue(evt2.EventTime > TimeSpan.FromSeconds(114));
            Assert.IsTrue(evt2.Assisters.Contains("KiraNi"));
            Assert.AreEqual("imFloppy", evt2.KillerName);
            Assert.AreEqual("Wei WuXian", evt2.VictimName);
        }
    }
}
