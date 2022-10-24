using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.League.Challenges;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.League.Tournament;

namespace craftersmine.Riot.Api.Tests.League
{
    [TestClass]
    public class TournamentApiTests
    {
        public const string TestSummonerId = "zQCXBkL1w3w6JQMW2GrPlepMI_IhaC4zcSyePpXAkxKXcrs";

        public RiotLeagueTournamentApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new RiotLeagueTournamentApiClient(RiotApiClientSettingsBuilder.CreateSettingsBuilder(ApiKey).UseTournamentStub().Build());
        }

        [TestMethod]
        public async Task TournamentStubTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized");
            LeagueTournamentProviderRegistrationParameters providerRegistrationParameters =
                new LeagueTournamentProviderRegistrationParameters(RiotPlatform.Russia, "http://localhost");
            int providerId =
                await Client.RegisterLeagueTournamentProviderAsync(providerRegistrationParameters);
            Assert.IsTrue(providerId > 0, "No provider ID fetched, provider probably not registered");
            LeagueTournamentRegistrationParameters tournamentRegistrationParameters =
                new LeagueTournamentRegistrationParameters("Test Tournament", providerId);
            int tournamentId =
                await Client.RegisterLeagueTournamentAsync(tournamentRegistrationParameters);
            Assert.IsTrue(tournamentId > 0, "No tournament ID fetched, tournament probably no registered");

            LeagueTournamentCodeParameters tournamentCodeParameters = new LeagueTournamentCodeParameters(null,
                LeaguePickType.Draft, LeagueMapType.SummonersRift, LeagueSpectatorType.All, 5);
            string[] tournamentCodes =
                await Client.CreateTournamentCodesAsync(tournamentCodeParameters, tournamentId);
            Assert.IsTrue(tournamentCodes.Length > 0 && tournamentCodes.Length == 1, "No tournament code fetched");
            tournamentCodes = await Client.CreateTournamentCodesAsync(tournamentCodeParameters, tournamentId, 50);
            Assert.IsTrue(tournamentCodes.Length > 0 && tournamentCodes.Length == 50);

            LeagueTournamentEvent[] tournamentEvents =
                await Client.GetLobbyEventsByTournamentCodeAsync(tournamentCodes[0]);
            Assert.IsTrue(tournamentEvents.Any(), "No tournament events fetched");
            DateTime evtTimestamp = new DateTime(2009, 02, 13, 11, 31, 30);
            foreach (var evt in tournamentEvents)
            {
                Assert.IsTrue(evt.Timestamp >= evtTimestamp, "Event timestamp is less than " + evtTimestamp.ToString());
                if (!string.IsNullOrWhiteSpace(evt.SummonerId))
                    Assert.AreEqual(TestSummonerId, evt.SummonerId, "Event summoner ID (if it is set) is not " + TestSummonerId);
            }
        }
    }
}
