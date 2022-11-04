using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.Summoner;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.League.Matches;
using Newtonsoft.Json;
using craftersmine.Riot.Api.League.Matches.Timeline;
using craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class MatchesTimelineApiClientTests : MatchesApiClientTests
    {
        public const int DataVersion = 2;

        public new LeagueMatchTimelineApiClient? Client { get; set; }

        public new void GetMatchesForPlayerByPuuidTests() {}

        public new void GetMatchInfoByMatchIdTests() {}

        [TestInitialize]
        public new void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new LeagueMatchTimelineApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }
        
        [TestMethod]
        public async Task GetMatchTimelineByMatchIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            LeagueMatchTimeline match = await Client.GetMatchTimelineByMatchIdAsync(RiotRegion.Europe, GameId);

            Assert.AreEqual(GameId, match.Metadata.MatchId, "Match ID is not " + GameId);
            Assert.AreEqual(DataVersion, match.Metadata.DataVersion, "Data version is not " + DataVersion);
            Assert.IsTrue(match.Metadata.Participants.Contains(MyPuuid), "Match timeline metadata participants doesn't contain PUUID: " + MyPuuid);
            Assert.IsNotNull(match.Timeline.Participants.FirstOrDefault(p => p.Puuid == MyPuuid), "No participant found on timeline data with PUUID: " + MyPuuid);
            Assert.AreEqual(GameIdLong, match.Timeline.GameId, "Game IDs doesn't match " + GameIdLong);
            Assert.AreEqual(TimeSpan.FromMinutes(1), match.Timeline.FrameInterval, "Frame Intervals are not same!");
            Assert.AreEqual(1, match.Timeline.Frames[0].Events.GetEventsOfType<PauseEndTimelineFrameEvent>().Length, "No PauseEnd timeline events found in first frame!");
            Assert.AreEqual(1, match.Timeline.Frames[^1].Events.GetEventsOfType<GameEndFrameEvent>().Length, "No GameEnd timeline events found in last frame!");
        }
    }
}
