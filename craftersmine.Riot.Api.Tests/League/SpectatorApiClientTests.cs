﻿using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.Spectator;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common.Exceptions;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class SpectatorApiClientTests
    {
        public const string MySummonerId = "PtRpTVHs2N12hcdRB5OgxNcs2y4wAK7yg4K38y8028YwBGw";
        
        public RiotLeagueSpectatorApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new RiotLeagueSpectatorApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetFeaturedGamesTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueCurrentFeaturedGamesInformation featuredGamesInformation = await Client.GetCurrentFeaturedGames(RiotPlatform.Russia);
            Assert.IsTrue(featuredGamesInformation.GameList.Any(), "Featured games list fetched empty");
            Assert.IsTrue(featuredGamesInformation.ClientRefreshInterval > TimeSpan.Zero, "Client refresh interval is 0");
        }

        [TestMethod]
        public async Task GetCurrentGameTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            try
            {
                LeagueCurrentGameInfo currentGameInfo =
                    await Client.GetCurrentGameBySummonerId(RiotPlatform.Russia, MySummonerId);
                Assert.AreEqual(RiotPlatform.Russia, currentGameInfo.ServerId, "League game server region is not " + RiotPlatform.Russia);
                Assert.IsTrue(currentGameInfo.GameId > 0, "Game ID is not fetched properly");
                Assert.AreEqual(11, currentGameInfo.MapId, "Map ID is not correct for Summoners Rift");
                Assert.IsTrue(currentGameInfo.BannedChampions.Any(), "No banned champions");
            }
            catch (RiotApiException e)
            {
                if (e.ResponseCode == HttpResponseCode.NotFound)
                    Assert.Inconclusive("Unable to finish test due to summoner is currently not playing any game");

                throw;
            }
        }
    }
}
