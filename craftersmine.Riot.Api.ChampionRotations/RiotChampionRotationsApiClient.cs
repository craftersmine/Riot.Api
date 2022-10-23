﻿using System.Threading.Tasks;
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
        /// Gets current League of Legends champion rotations in specified server
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <returns>An information about current champion rotations in specified region</returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<ChampionRotationsInfo> GetCurrentChampionRotationsForRegionAsync(RiotPlatform region)
        {
            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "champion-rotations"));

            ChampionRotationsInfo rotations = await Client.Get<ChampionRotationsInfo>(endpoint, null);
            return rotations;
        }
    }
}
