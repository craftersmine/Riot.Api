using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.Status
{
    public class RiotServiceStatusApiClient : RiotApiClient
    {
        public RiotServiceStatusApiClient(RiotApiClientSettings settings) : base(settings)
        { }

        public async Task<RiotServiceStatus> GetLeagueStatusForRegionAsync(RiotPlatform serverRegion)
        {
            string endpoint =
                UriUtils.GetAddress(serverRegion, UriUtils.JoinEndpoints("/lol/status/v4", "platform-data"));

            RiotServiceStatus serviceStatus = await Client.Get<RiotServiceStatus>(endpoint, null);
            return serviceStatus;
        }

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
    }
}
