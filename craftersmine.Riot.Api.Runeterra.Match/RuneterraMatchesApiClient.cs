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

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, puuid));

            string[] matches = await Client.GetAsync<string[]>(endpoint, null);
            return matches;
        }
    }
}
