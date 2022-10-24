using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.Tournament
{
    public class RiotLeagueTournamentApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lol/tournament/v4/";
        private const string ApiStubEndpointRoot = "/lol/tournament-stub/v4/";

        public RiotLeagueTournamentApiClient(RiotApiClientSettings settings) : base(settings) { }

        public async Task<int> RegisterLeagueTournamentProviderAsync(RiotRegion region,
            LeagueTournamentProviderRegistrationParameters providerRegistrationParameters)
        {
            if (providerRegistrationParameters is null)
                throw new ArgumentNullException(nameof(providerRegistrationParameters));

            string endpoint = string.Empty;

            if (Settings.UseTournamentStub)
                endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiStubEndpointRoot, "provider"));
            else endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "provider"));

            int providerId = await Client.Post<int>(endpoint, null, providerRegistrationParameters);
            return providerId;
        }

        public async Task<int> RegisterLeagueTournamentAsync(RiotRegion region,
            LeagueTournamentRegistrationParameters tournamentRegistrationParameters)
        {
            if (tournamentRegistrationParameters is null)
                throw new ArgumentNullException(nameof(tournamentRegistrationParameters));

            string endpoint = string.Empty;

            if (Settings.UseTournamentStub)
                endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiStubEndpointRoot, "tournaments"));
            else endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "provider"));

            int tournamentId = await Client.Post<int>(endpoint, null, tournamentRegistrationParameters);
            return tournamentId;
        }

        public async Task<string[]> CreateTournamentCodesAsync(RiotRegion region,
            LeagueTournamentCodeParameters tournamentCodeParameters, int tournamentId, int count)
        {
            if (tournamentCodeParameters is null)
                throw new ArgumentNullException(nameof(tournamentCodeParameters));

            if (count < 1 || count > 1000)
                throw new ArgumentOutOfRangeException(nameof(count),
                    "Tournament codes count requested cannot be less than 1 or more than 1000");
            
            string endpoint = string.Empty;

            if (Settings.UseTournamentStub)
                endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiStubEndpointRoot, "codes"));
            else endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "codes"));

            string[] tournamentCodes = await Client.Post<string[]>(endpoint, null, tournamentCodeParameters);
            return tournamentCodes;
        }

        public async Task<LeagueTournamentEvent[]> GetLobbyEventsByTournamentCodeAsync(RiotRegion region,
            string tournamentCode)
        {
            if (string.IsNullOrWhiteSpace(tournamentCode))
                throw new ArgumentNullException(nameof(tournamentCode));

            string endpoint = string.Empty;

            if (Settings.UseTournamentStub)
                endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiStubEndpointRoot, "lobby-events/by-code", tournamentCode));
            else endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "lobby-events/by-code", tournamentCode));

            LeagueTournamentEvent[] tournamentEvents = await Client.Get<LeagueTournamentEvent[]>(endpoint, null);
            return tournamentEvents;
        }
    }
}
