using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.Valorant.Ranked
{
    /// <summary>
    /// Represents a Valorant Ranked v1 API client
    /// </summary>
    public class ValorantRankedApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/val/ranked/v1";
        
        /// <summary>
        /// Creates a new instance of <see cref="ValorantRankedApiClient"/> with specified settings
        /// </summary>
        /// <param name="settings">Settings for <see cref="ValorantRankedApiClient"/></param>
        public ValorantRankedApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets a Valorant leaderboard for specified region
        /// </summary>
        /// <param name="region">Valorant shard region</param>
        /// <param name="actId">Valorant act ID</param>
        /// <param name="size">Number of entries (min 1, max 200, default 200)</param>
        /// <param name="startIndex">Start index from what start to fetch data (default 0)</param>
        /// <returns>A <see cref="ValorantLeaderboard"/> for specified shard region</returns>
        /// <exception cref="ArgumentException">When shard region is not Valorant related (ex. LoR or Unknown)</exception>
        /// <exception cref="ArgumentOutOfRangeException">When size is less than 1 or more than 200, or when start index is less than 0</exception>
        /// <exception cref="ArgumentNullException">When act ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<ValorantLeaderboard> GetLeaderboardByActIdAsync(RiotShards region, string actId, int size, int startIndex)
        {
            if (region == RiotShards.Unknown || region == RiotShards.LoRAmericas || region == RiotShards.LoRAsiaPacific || region == RiotShards.LoREurope)
                throw new ArgumentException("Unexpected value for region: " + region.GetShardString() + " - " + region.ToString(), nameof(region));

            if (string.IsNullOrWhiteSpace(actId))
                throw new ArgumentNullException(nameof(actId));

            if (size > 200 || size < 1)
                throw new ArgumentOutOfRangeException(nameof(size),
                    "Number of entries cannot be less than 1 or more than 200");

            if (startIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Start index cannot be less than 1");

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "leaderboards/by-act/", actId));

            ValorantLeaderboard leaderboard = await Client.GetAsync<ValorantLeaderboard>(endpoint,
                new Dictionary<string, object>() {{"size", size}, {"startIndex", startIndex}});
            return leaderboard;
        }

        /// <inheritdoc cref="GetLeaderboardByActIdAsync(RiotShards,string,int,int)"/>
        public async Task<ValorantLeaderboard> GetLeaderboardByActIdAsync(RiotShards region, Guid actId, int size, int startindex)
        {
            return await GetLeaderboardByActIdAsync(region, actId.ToString(), size, startindex);
        }
        
        /// <inheritdoc cref="GetLeaderboardByActIdAsync(RiotShards,string,int,int)"/>
        public async Task<ValorantLeaderboard> GetLeaderboardByActIdAsync(RiotShards region, string actId, int size)
        {
            return await GetLeaderboardByActIdAsync(region, actId, size, 0);
        }
        
        /// <inheritdoc cref="GetLeaderboardByActIdAsync(RiotShards,string,int,int)"/>
        public async Task<ValorantLeaderboard> GetLeaderboardByActIdAsync(RiotShards region, Guid actId, int size)
        {
            return await GetLeaderboardByActIdAsync(region, actId, size, 0);
        }
        
        /// <inheritdoc cref="GetLeaderboardByActIdAsync(RiotShards,string,int,int)"/>
        public async Task<ValorantLeaderboard> GetLeaderboardByActIdAsync(RiotShards region, string actId)
        {
            return await GetLeaderboardByActIdAsync(region, actId, 200, 0);
        }
        
        /// <inheritdoc cref="GetLeaderboardByActIdAsync(RiotShards,string,int,int)"/>
        public async Task<ValorantLeaderboard> GetLeaderboardByActIdAsync(RiotShards region, Guid actId)
        {
            return await GetLeaderboardByActIdAsync(region, actId, 200, 0);
        }
    }
}
