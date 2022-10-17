using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.ChampionRotations
{
    /// <summary>
    /// Represents Riot League of Legends Champion v3 API
    /// </summary>
    public class RiotChampionRotationsApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lol/platform/v3/";

        /// <summary>
        /// Creates a new instance of <see cref="RiotChampionRotationsApiClient"/> instance
        /// </summary>
        /// <param name="settings">Settings for <see cref="RiotChampionRotationsApiClient"/></param>
        public RiotChampionRotationsApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        public async Task<ChampionRotationsInfo> GetCurrentChampionRotationsForRegionAsync(RiotPlatform region)
        {
            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "champion-rotations"));

            ChampionRotationsInfo rotations = await Client.Get<ChampionRotationsInfo>(endpoint, null);
            return rotations;
        }
    }
}
