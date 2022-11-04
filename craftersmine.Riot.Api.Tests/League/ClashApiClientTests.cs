using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.Summoner;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common.Utils;
using craftersmine.Riot.Api.League.Clash;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class ClashApiClientTests
    {
        public const int TournamentId = 2921;
        public const int TournamentThemeId = 30;
        public const long TournamentScheduleRegTime = 1665932400000;
        public const long TournamentScheduleStartTime = 1665939600000;
        public const string TournamentNameKey = "worlds2022";
        public const string TournamentNameSecondaryKey = "day_4";
        public const string TeamId = "c9fee353-d9bf-4dcd-a38a-e54c1e003db4";
        public const string CaptainSummonerId = "NwUQy3eGM4_eEaHA6SsKQ5YwRGc77nvwDdfq6NKUmzNXx-ay1ByLBsZ2ZQ";

        public LeagueClashApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new LeagueClashApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetClashTournamentsTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            LeagueClashTournament[] tournaments = await Client.GetClashTournamentsAsync(RiotPlatform.Russia);
            if (!tournaments.Any())
                Assert.Inconclusive("No active or upcoming Clash tournaments are fetched. Might be that there are no Clash tournaments currently available. Test unclear");
        }

        [TestMethod]
        public async Task GetClashPlayersBySummonerIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            LeagueClashPlayer[] players =
                await Client.GetClashPlayersBySummonerIdAsync(RiotPlatform.Russia, CaptainSummonerId);
            if (!players.Any())
                Assert.Inconclusive("No active or upcoming Clash players are fetched for this captain summoner ID. Might be that there are no Clash tournaments currently available. Test unclear");
        }

        [TestMethod]
        public async Task GetClashTeamByIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            LeagueClashTeam team =
                await Client.GetClashTeamByIdAsync(RiotPlatform.Russia, TeamId);
            Assert.AreEqual(TeamId, team.Id, "Team ID is mismatched");
            Assert.AreEqual(CaptainSummonerId, team.CaptainSummonerId, "Captain ID is mismatched");
            Assert.AreEqual(TournamentId, team.TournamentId, "Tournament ID is mismatched");
        }

        [TestMethod]
        public async Task GetClashTournamentByTeamIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            LeagueClashTournament tournament =
                await Client.GetClashTournamentByTeamIdAsync(RiotPlatform.Russia, TeamId);
            Assert.AreEqual(TournamentId, tournament.Id, "Tournament ID is mismatched");
            Assert.AreEqual(TournamentNameKey, tournament.NameKey, "Tournament Name key is mismatched");
            Assert.AreEqual(TournamentNameSecondaryKey, tournament.NameSecondaryKey, "Tournament Secondary Name key is mismatched");
            Assert.AreEqual(TournamentThemeId, tournament.ThemeId, "Tournament theme ID is mismatched");
            Assert.IsTrue(tournament.Schedule.Any(), "No scheduled tournaments fetched");
            Assert.AreEqual(TournamentId, tournament.Schedule[0].Id, "First scheduled tournament ID is mismatched");
            Assert.AreEqual(false, tournament.Schedule[0].IsCancelled, "First scheduled tournament is cancelled, expected not");
            Assert.AreEqual(TournamentScheduleRegTime.FromUnixTimeMilliseconds(), tournament.Schedule[0].RegistrationTime, "First scheduled tournament registration time is mismatched");
            Assert.AreEqual(TournamentScheduleStartTime.FromUnixTimeMilliseconds(), tournament.Schedule[0].StartTime, "First scheduled tournament start time is mismatched");
        }

        
        [TestMethod]
        public async Task GetClashTournamentByIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            LeagueClashTournament tournament =
                await Client.GetClashTournamentByIdAsync(RiotPlatform.Russia, TournamentId);
            Assert.AreEqual(TournamentId, tournament.Id, "Tournament ID is mismatched");
            Assert.AreEqual(TournamentNameKey, tournament.NameKey, "Tournament Name key is mismatched");
            Assert.AreEqual(TournamentNameSecondaryKey, tournament.NameSecondaryKey, "Tournament Secondary Name key is mismatched");
            Assert.AreEqual(TournamentThemeId, tournament.ThemeId, "Tournament theme ID is mismatched");
            Assert.IsTrue(tournament.Schedule.Any(), "No scheduled tournaments fetched");
            Assert.AreEqual(TournamentId, tournament.Schedule[0].Id, "First scheduled tournament ID is mismatched");
            Assert.AreEqual(false, tournament.Schedule[0].IsCancelled, "First scheduled tournament is cancelled, expected not");
            Assert.AreEqual(TournamentScheduleRegTime.FromUnixTimeMilliseconds(), tournament.Schedule[0].RegistrationTime, "First scheduled tournament registration time is mismatched");
            Assert.AreEqual(TournamentScheduleStartTime.FromUnixTimeMilliseconds(), tournament.Schedule[0].StartTime, "First scheduled tournament start time is mismatched");
        }
    }
}
