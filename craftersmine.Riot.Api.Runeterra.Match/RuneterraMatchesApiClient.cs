using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.Runeterra.Matches
{
    /// <summary>
    /// Represents a Legends or Runeterra Matches v1 API client
    /// </summary>
    public class RuneterraMatchesApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lor/match/v1/";
        
        /// <summary>
        /// Creates a new instance of <see cref="RuneterraMatchesApiClient"/> instance
        /// </summary>
        /// <param name="settings">Settings for <see cref="RuneterraMatchesApiClient"/></param>
        public RuneterraMatchesApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets an array of match IDs that player played
        /// </summary>
        /// <param name="region">Legends of Runeterra data region</param>
        /// <param name="puuid">Player's Riot Account PUUID</param>
        /// <returns>An array of match IDs <see langword="string"/>s</returns>
        /// <exception cref="ArgumentNullException">When PUUID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<string[]> GetMatchesByPuuidAsync(RiotRegion region, string puuid)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "matches/by-puuid", puuid, "ids"));

            string[] matches = await Client.GetAsync<string[]>(endpoint, null);
            return matches;
        }

        /// <summary>
        /// Gets an information about Legends of Runeterra match by it's ID
        /// </summary>
        /// <param name="region">Legends of Runeterra data region</param>
        /// <param name="matchId">Legends of Runeterra match ID</param>
        /// <returns><see cref="RuneterraMatch"/> with match information and metadata</returns>
        /// <exception cref="ArgumentNullException">When match ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<RuneterraMatch> GetMatchByIdAsync(RiotRegion region, string matchId)
        {
            if (string.IsNullOrWhiteSpace(matchId))
                throw new ArgumentNullException(nameof(matchId));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "matches", matchId));

            RuneterraMatch match = await Client.GetAsync<RuneterraMatch>(endpoint, null);
            return match;
        }

        /// <inheritdoc cref="GetMatchByIdAsync(RiotRegion,string)"/>
        public async Task<RuneterraMatch> GetMatchByIdAsync(RiotRegion region, Guid matchId)
        {
            if (matchId == Guid.Empty)
                throw new ArgumentNullException(nameof(matchId));

            return await GetMatchByIdAsync(region, matchId.ToString());
        }
    }
}
