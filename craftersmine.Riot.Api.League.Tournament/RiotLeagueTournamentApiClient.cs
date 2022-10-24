using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;
using Newtonsoft.Json.Linq;

namespace craftersmine.Riot.Api.League.Tournament
{
    /// <summary>
    /// Represents a League of Legends Tournament API and Tournament API stub
    /// </summary>
    public class RiotLeagueTournamentApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lol/tournament/v4/";
        private const string ApiStubEndpointRoot = "/lol/tournament-stub/v4/";

        /// <summary>
        /// Creates new instance of <see cref="RiotLeagueTournamentApiClient"/> with specified settings
        /// </summary>
        /// <param name="settings">Settings for <see cref="RiotLeagueTournamentApiClient"/></param>
        public RiotLeagueTournamentApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Registers a new Tournament provider with specified parameters
        /// </summary>
        /// <param name="region">Riot Region on which perform request (recommended closest to your application host)</param>
        /// <param name="providerRegistrationParameters">Tournament Provider registration parameters</param>
        /// <returns>An <see langword="int"/> of new Tournament provider</returns>
        /// <exception cref="ArgumentNullException">When <see cref="providerRegistrationParameters"/> is null</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<int> RegisterLeagueTournamentProviderAsync(LeagueTournamentProviderRegistrationParameters providerRegistrationParameters)
        {
            if (providerRegistrationParameters is null)
                throw new ArgumentNullException(nameof(providerRegistrationParameters));

            string endpoint = string.Empty;

            if (Settings.UseTournamentStub)
                endpoint = UriUtils.GetAddress(RiotRegion.Americas, UriUtils.JoinEndpoints(ApiStubEndpointRoot, "providers"));
            else endpoint = UriUtils.GetAddress(RiotRegion.Americas, UriUtils.JoinEndpoints(ApiEndpointRoot, "providers"));

            int providerId = await Client.Post<int>(endpoint, null, providerRegistrationParameters);
            return providerId;
        }

        /// <summary>
        /// Registers a new Tournament with specified parameters
        /// </summary>
        /// <param name="region">Riot Region on which perform request (recommended closest to your application host)</param>
        /// <param name="tournamentRegistrationParameters">Tournament registration parameters</param>
        /// <returns>An <see langword="int"/> of new Tournament</returns>
        /// <exception cref="ArgumentNullException">When <see cref="tournamentRegistrationParameters"/> is null</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<int> RegisterLeagueTournamentAsync(LeagueTournamentRegistrationParameters tournamentRegistrationParameters)
        {
            if (tournamentRegistrationParameters is null)
                throw new ArgumentNullException(nameof(tournamentRegistrationParameters));

            string endpoint = string.Empty;

            if (Settings.UseTournamentStub)
                endpoint = UriUtils.GetAddress(RiotRegion.Americas, UriUtils.JoinEndpoints(ApiStubEndpointRoot, "tournaments"));
            else endpoint = UriUtils.GetAddress(RiotRegion.Americas, UriUtils.JoinEndpoints(ApiEndpointRoot, "tournaments"));

            int tournamentId = await Client.Post<int>(endpoint, null, tournamentRegistrationParameters);
            return tournamentId;
        }

        /// <summary>
        /// Creates a new Tournament codes with specified parameters
        /// </summary>
        /// <param name="region">Riot Region on which perform request (recommended closest to your application host)</param>
        /// <param name="tournamentCodeParameters">New Tournament game parameters</param>
        /// <param name="tournamentId">Tournament ID</param>
        /// <param name="amount">Amount of tournament codes to generate</param>
        /// <returns>An array of <see langword="string"/> with tournament codes</returns>
        /// <exception cref="ArgumentNullException">When <see cref="tournamentCodeParameters"/> is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">When <see cref="amount"/> is less than 1 or more than 1000</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<string[]> CreateTournamentCodesAsync(LeagueTournamentCodeParameters tournamentCodeParameters, int tournamentId, int amount)
        {
            if (tournamentCodeParameters is null)
                throw new ArgumentNullException(nameof(tournamentCodeParameters));

            if (amount < 1 || amount > 1000)
                throw new ArgumentOutOfRangeException(nameof(amount),
                    "Tournament codes count requested cannot be less than 1 or more than 1000");
            
            string endpoint = string.Empty;

            if (Settings.UseTournamentStub)
                endpoint = UriUtils.GetAddress(RiotRegion.Americas, UriUtils.JoinEndpoints(ApiStubEndpointRoot, "codes"));
            else endpoint = UriUtils.GetAddress(RiotRegion.Americas, UriUtils.JoinEndpoints(ApiEndpointRoot, "codes"));

            string[] tournamentCodes = await Client.Post<string[]>(endpoint, new Dictionary<string, object>() {{"tournamentId", tournamentId}, {"count", amount}}, tournamentCodeParameters);
            return tournamentCodes;
        }
        
        /// <summary>
        /// Creates a new Tournament codes with specified parameters
        /// </summary>
        /// <param name="region">Riot Region on which perform request (recommended closest to your application host)</param>
        /// <param name="tournamentCodeParameters">New Tournament game parameters</param>
        /// <param name="tournamentId">Tournament ID</param>
        /// <returns>An array of <see langword="string"/> with tournament codes</returns>
        /// <exception cref="ArgumentNullException">When <see cref="tournamentCodeParameters"/> is null</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<string[]> CreateTournamentCodesAsync(LeagueTournamentCodeParameters tournamentCodeParameters, int tournamentId)
        {
            if (tournamentCodeParameters is null)
                throw new ArgumentNullException(nameof(tournamentCodeParameters));

            string endpoint = string.Empty;

            if (Settings.UseTournamentStub)
                endpoint = UriUtils.GetAddress(RiotRegion.Americas, UriUtils.JoinEndpoints(ApiStubEndpointRoot, "codes"));
            else endpoint = UriUtils.GetAddress(RiotRegion.Americas, UriUtils.JoinEndpoints(ApiEndpointRoot, "codes"));

            string[] tournamentCodes = await Client.Post<string[]>(endpoint, new Dictionary<string, object>() {{"tournamentId", tournamentId}}, tournamentCodeParameters);
            return tournamentCodes;
        }

        /// <summary>
        /// Gets a Tournament lobby events by tournament code
        /// </summary>
        /// <param name="region">Riot Region on which perform request (recommended closest to your application host)</param>
        /// <param name="tournamentCode">League of Legends tournament code</param>
        /// <returns>An array of <see cref="LeagueTournamentEvent"/> for lobby of specified tournament code</returns>
        /// <exception cref="ArgumentNullException">When tournament code is <see langword="null"/> or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueTournamentEvent[]> GetLobbyEventsByTournamentCodeAsync(string tournamentCode)
        {
            if (string.IsNullOrWhiteSpace(tournamentCode))
                throw new ArgumentNullException(nameof(tournamentCode));

            string endpoint = string.Empty;

            if (Settings.UseTournamentStub)
                endpoint = UriUtils.GetAddress(RiotRegion.Americas, UriUtils.JoinEndpoints(ApiStubEndpointRoot, "lobby-events/by-code", tournamentCode));
            else endpoint = UriUtils.GetAddress(RiotRegion.Americas, UriUtils.JoinEndpoints(ApiEndpointRoot, "lobby-events/by-code", tournamentCode));

            JObject tournamentEventsRaw = await Client.Get<JObject>(endpoint, null);
            LeagueTournamentEvent[] tournamentEvents = tournamentEventsRaw.GetValue("eventList")?.ToObject<LeagueTournamentEvent[]>();
            return tournamentEvents;
        }

        /// <summary>
        /// Gets a Tournament information by tournament code
        /// </summary>
        /// <param name="region">Riot Region on which perform request (recommended closest to your application host)</param>
        /// <param name="tournamentCode">League of Legends tournament code</param>
        /// <returns>A tournament information</returns>
        /// <exception cref="TournamentStubUsedException">When API client initialized with using Tournament Stub</exception>
        /// <exception cref="ArgumentNullException">When tournament code is <see langword="null"/> or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueTournamentCode> GetTournamentInfoByCodeAsync(string tournamentCode)
        {
            if (Settings.UseTournamentStub)
                throw new TournamentStubUsedException("This endpoint is not available in Tournament Stub API. Use full Tournament API to access this method");

            if (string.IsNullOrWhiteSpace(tournamentCode))
                throw new ArgumentNullException(nameof(tournamentCode));

            string endpoint =
                UriUtils.GetAddress(RiotRegion.Americas, UriUtils.JoinEndpoints(ApiEndpointRoot, "codes", tournamentCode));

            LeagueTournamentCode tournamentCodeData = await Client.Get<LeagueTournamentCode>(endpoint, null);
            return tournamentCodeData;
        }

        /// <summary>
        /// Updates Tournament information by tournament code with specified data
        /// </summary>
        /// <param name="region">Riot Region on which perform request (recommended closest to your application host)</param>
        /// <param name="tournamentCode">League of Legends tournament code</param>
        /// <param name="tournamentCodeUpdateParameters">New parameters for tournament data</param>
        /// <exception cref="TournamentStubUsedException">When API client initialized with using Tournament Stub</exception>
        /// <exception cref="ArgumentNullException">When tournament code is <see langword="null"/> or empty or <see cref="tournamentCodeUpdateParameters"/> is <see langword="null"/></exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task UpdateTournamentInfoByCodeAsync(string tournamentCode,
            LeagueTournamentCodeUpdateParameters tournamentCodeUpdateParameters)
        {
            if (Settings.UseTournamentStub)
                throw new TournamentStubUsedException("This endpoint is not available in Tournament Stub API. Use full Tournament API to access this method");

            if (string.IsNullOrWhiteSpace(tournamentCode))
                throw new ArgumentNullException(nameof(tournamentCode));
            if (tournamentCodeUpdateParameters is null)
                throw new ArgumentNullException(nameof(tournamentCodeUpdateParameters));

            string endpoint =
                UriUtils.GetAddress(RiotRegion.Americas, UriUtils.JoinEndpoints(ApiEndpointRoot, "codes", tournamentCode));

            await Client.Put<object>(endpoint, null, tournamentCodeUpdateParameters);
        }
    }
}
