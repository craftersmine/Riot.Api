using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.Runeterra.Ranked
{
    /// <summary>
    /// Represents a Legends or Runeterra Ranked v1 API client
    /// </summary>
    public class RuneterraRankedApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lor/ranked/v1";
        
        /// <summary>
        /// Creates a new instance of <see cref="RuneterraRankedApiClient"/> instance
        /// </summary>
        /// <param name="settings">Settings for <see cref="RuneterraRankedApiClient"/></param>
        public RuneterraRankedApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets a Legends of Runeterra Ranked Leaderboard for specified region
        /// </summary>
        /// <param name="region">Legends or Runeterra server region</param>
        /// <returns>An array of Legends of Runeterra players in leaderboard</returns>
        /// <exception cref="ArgumentException">When region not Legends of Runeterra related or unknown is selected</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
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
