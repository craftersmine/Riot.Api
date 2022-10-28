using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.Tft.Matches
{
    public class RiotTftMatchesApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/tft/match/v1/matches";

        public RiotTftMatchesApiClient(RiotApiClientSettings settings) : base(settings) { }

        public async Task<TftMatch> GetMatchByIdAsync(RiotRegion region, string matchId)
        {
            if (string.IsNullOrWhiteSpace(matchId))
                throw new ArgumentNullException(nameof(matchId));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, matchId));

            TftMatch match = await Client.Get<TftMatch>(endpoint, null);
            return match;
        }
    }
}
