using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.Runeterra.Ranked
{
    public class RuneterraRankedApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lor/ranked/v1";

        public RuneterraRankedApiClient(RiotApiClientSettings settings) : base(settings) { }

        public async Task<RuneterraPlayer[]> GetLeaderboardAsync(RiotShards region)
        {
            if (region == RiotShards.Unknown || region == RiotShards.ValorantAsiaPacific ||
                region == RiotShards.ValorantEurope || region == RiotShards.ValorantNorthAmerica ||
                region == RiotShards.ValorantLatinAmerica || region == RiotShards.ValorantKorea ||
                region == RiotShards.ValorantBrazil)
                throw new ArgumentException("Invalid LoR region selected! " + region, nameof(region));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "leaderboards"));

            RuneterraPlayer[] leaderboard = await Client.GetAsync<RuneterraPlayer[]>(endpoint, null);
            return leaderboard;
        }
    }
}
