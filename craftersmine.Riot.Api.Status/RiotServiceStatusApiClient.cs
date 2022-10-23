using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.Status
{
    /// <summary>
    /// Represents a Riot Services Status API client
    /// </summary>
    public class RiotServiceStatusApiClient : RiotApiClient
    {
        /// <summary>
        /// Creates a new instance of <see cref="RiotServiceStatusApiClient"/> with specified settings
        /// </summary>
        /// <param name="settings"></param>
        public RiotServiceStatusApiClient(RiotApiClientSettings settings) : base(settings)
        { }

        /// <summary>
        /// Gets a Status for League of Legends server
        /// </summary>
        /// <param name="serverRegion">League of Legends server location</param>
        /// <returns>A status for specified League of Legends server</returns>
        public async Task<RiotServiceStatus> GetLeagueStatusForRegionAsync(RiotPlatform serverRegion)
        {
            string endpoint =
                UriUtils.GetAddress(serverRegion, UriUtils.JoinEndpoints("/lol/status/v4", "platform-data"));

            RiotServiceStatus serviceStatus = await Client.Get<RiotServiceStatus>(endpoint, null);
            return serviceStatus;
        }
        
        /// <summary>
        /// Gets a Status for Valorant server
        /// </summary>
        /// <param name="serverRegion">Valorant server location</param>
        /// <returns>A status for specified Valorant server</returns>
        public async Task<RiotServiceStatus> GetValorantStatusForRegionAsync(RiotShards serverRegion)
        {
            if (serverRegion == RiotShards.Unknown || serverRegion == RiotShards.LoREurope ||
                serverRegion == RiotShards.LoRAmericas || serverRegion == RiotShards.LoRAsiaPacific)
                throw new ArgumentException("Unknown server region selected to fetch Valorant status",
                    nameof(serverRegion));
            
            string endpoint =
                UriUtils.GetAddress(serverRegion, UriUtils.JoinEndpoints("/val/status/v1", "platform-data"));
            
            RiotServiceStatus serviceStatus = await Client.Get<RiotServiceStatus>(endpoint, null);
            return serviceStatus;
        }
        
        /// <summary>
        /// Gets a Status for Legends of Runeterra server
        /// </summary>
        /// <param name="serverRegion">Legends of Runeterra server location</param>
        /// <returns>A status for specified Legends of Runeterra server</returns>
        public async Task<RiotServiceStatus> GetLoRStatusForRegionAsync(RiotShards serverRegion)
        {
            if (serverRegion == RiotShards.Unknown || serverRegion == RiotShards.ValorantAsiaPacific ||
                serverRegion == RiotShards.ValorantBrazil || serverRegion == RiotShards.ValorantEurope ||
                serverRegion == RiotShards.ValorantKorea || serverRegion == RiotShards.ValorantLatinAmerica ||
                serverRegion == RiotShards.ValorantNorthAmerica)
                throw new ArgumentException("Unknown server region selected to fetch Legends of Runeterra status",
                    nameof(serverRegion));

            string endpoint =
                UriUtils.GetAddress(serverRegion, UriUtils.JoinEndpoints("/lor/status/v1", "platform-data"));
            
            RiotServiceStatus serviceStatus = await Client.Get<RiotServiceStatus>(endpoint, null);
            return serviceStatus;
        }
    }
}
