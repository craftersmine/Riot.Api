using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.Runeterra.Match
{
    public class RuneterraMatchesApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lor/match/v1/";

        public RuneterraMatchesApiClient(RiotApiClientSettings settings) : base(settings) { }

        public async Task<string[]> GetMatchesByPuuidAsync(RiotRegion region, string puuid)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "matches/by-puuid", puuid, "ids"));

            string[] matches = await Client.GetAsync<string[]>(endpoint, null);
            return matches;
        }

        public async Task<RuneterraMatch> GetMatchByIdAsync(RiotRegion region, string matchId)
        {
            if (string.IsNullOrWhiteSpace(matchId))
                throw new ArgumentNullException(nameof(matchId));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "matches", matchId));

            RuneterraMatch match = await Client.GetAsync<RuneterraMatch>(endpoint, null);
            return match;
        }

        public async Task<RuneterraMatch> GetMatchByIdAsync(RiotRegion region, Guid matchId)
        {
            if (matchId == Guid.Empty)
                throw new ArgumentNullException(nameof(matchId));

            return await GetMatchByIdAsync(region, matchId.ToString());
        }
    }
}
