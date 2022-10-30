using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.Tft.Matches
{
    /// <summary>
    /// Represents a Teamfight Tactics Match v1 API client
    /// </summary>
    public class TftMatchesApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/tft/match/v1/matches";

        /// <summary>
        /// Creates a new instance <see cref="TftMatchesApiClient"/> with specified settings
        /// </summary>
        /// <param name="settings">Settings for <see cref="TftMatchesApiClient"/></param>
        public TftMatchesApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets Teamfight Tactics match information by match ID
        /// </summary>
        /// <param name="region">Teamfight Tactics region on which perform request</param>
        /// <param name="matchId">Teamfight Tactics match ID</param>
        /// <returns>Information about Teamfight Tactics match</returns>
        /// <exception cref="ArgumentNullException">When match ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<TftMatch> GetMatchByIdAsync(RiotRegion region, string matchId)
        {
            if (string.IsNullOrWhiteSpace(matchId))
                throw new ArgumentNullException(nameof(matchId));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, matchId));

            TftMatch match = await Client.Get<TftMatch>(endpoint, null);
            return match;
        }

        /// <summary>
        /// Gets an array of matches IDs for player with specified Riot Account PUUID
        /// </summary>
        /// <param name="region">Teamfight Tactics region on which perform request</param>
        /// <param name="puuid">Riot Account PUUID</param>
        /// <param name="startTime">Start time after which fetch matches</param>
        /// <param name="endTime">End time before which fetch matches</param>
        /// <param name="startIndex">Start index for matches</param>
        /// <param name="amount">Amount of entries to fetch</param>
        /// <returns>An array <see cref="string"/>'s of match IDs</returns>
        /// <exception cref="ArgumentNullException">When Riot Account PUUID is null or empty</exception>
        /// <exception cref="ArgumentOutOfRangeException">When start index is less than 0 or amount is less than 1</exception>
        /// <exception cref="ArgumentException">When start time bigger than end time</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<string[]> GetMatchesForSummonerByPuuidAsync(RiotRegion region, string puuid,
            DateTime startTime, DateTime endTime, int startIndex, int amount)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            if (startIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Cannot set start index");

            if (amount < 1)
                throw new ArgumentOutOfRangeException(nameof(amount), "Cannot set amount less than 1");

            if (endTime < startTime)
                throw new ArgumentException(nameof(endTime), "End time is less than start time");

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-puuid", puuid, "ids"));

            Dictionary<string, object> queryParams = new Dictionary<string, object>()
            {
                { "start", startIndex },
                { "startTime", startTime.ToUnixTimeSeconds() },
                { "endTime", endTime.ToUnixTimeSeconds()},
                { "count", amount }
            };

            string[] matches = await Client.Get<string[]>(endpoint, queryParams);
            return matches;
        }

        /// <inheritdoc cref="GetMatchesForSummonerByPuuidAsync(RiotRegion,string,DateTime,DateTime,int,int)"/>
        public async Task<string[]> GetMatchesForSummonerByPuuidAsync(RiotRegion region, string puuid, int startIndex,
            int amount)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            if (startIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Cannot set start index");

            if (amount < 1)
                throw new ArgumentOutOfRangeException(nameof(amount), "Cannot set amount less than 1");
            
            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-puuid", puuid, "ids"));

            Dictionary<string, object> queryParams = new Dictionary<string, object>()
            {
                { "start", startIndex },
                { "count", amount }
            };

            string[] matches = await Client.Get<string[]>(endpoint, queryParams);
            return matches;
        }
        
        /// <inheritdoc cref="GetMatchesForSummonerByPuuidAsync(RiotRegion,string,DateTime,DateTime,int,int)"/>
        public async Task<string[]> GetMatchesForSummonerByPuuidAsync(RiotRegion region, string puuid,
            DateTime startTime, DateTime endTime)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));
            
            if (endTime < startTime)
                throw new ArgumentOutOfRangeException(nameof(endTime), "End time is less than start time");
            
            if (startTime < endTime)
                throw new ArgumentOutOfRangeException(nameof(startTime), "End time is less than start time");
            
            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-puuid", puuid, "ids"));

            
            Dictionary<string, object> queryParams = new Dictionary<string, object>()
            {
                { "startTime", startTime.ToUnixTimeSeconds() },
                { "endTime", endTime.ToUnixTimeSeconds()}
            };

            string[] matches = await Client.Get<string[]>(endpoint, queryParams);
            return matches;
        }
        
        /// <inheritdoc cref="GetMatchesForSummonerByPuuidAsync(RiotRegion,string,DateTime,DateTime,int,int)"/>
        public async Task<string[]> GetMatchesForSummonerByPuuidAsync(RiotRegion region, string puuid)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-puuid", puuid, "ids"));

            string[] matches = await Client.Get<string[]>(endpoint, new Dictionary<string, object>() { { "count", 20 } });
            return matches;
        }
    }
}
