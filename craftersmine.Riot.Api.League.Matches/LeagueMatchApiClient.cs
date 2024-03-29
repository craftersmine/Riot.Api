﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a Riot Match v5 API
    /// </summary>
    public class LeagueMatchApiClient : RiotApiClient
    {
        /// <summary>
        /// Gets a root for Riot Match v5 API endpoints
        /// </summary>
        protected const string ApiEndpointRoot = "/lol/match/v5/matches";

        /// <summary>
        /// Creates a new instance of <see cref="LeagueMatchApiClient"/> instance
        /// </summary>
        /// <param name="settings">Settings for <see cref="LeagueMatchApiClient"/></param>
        public LeagueMatchApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets a list of match IDs for player by specified Riot PUUID
        /// </summary>
        /// <remarks>
        ///  Americas Data region serves: NA, BR, LAN, LAS <br/>
        ///  Asia Data region serves: KR, JP <br/>
        ///  Europe Data region serves: EUNE, EUW, TR, RU <br/>
        ///  Sea Data region serves: OCE
        /// </remarks>
        /// <param name="region">Riot Data Region</param>
        /// <param name="puuid">Riot Account PUUID</param>
        /// <param name="startTime">Start <see cref="DateTime"/> for filters</param>
        /// <param name="endTime">End <see cref="DateTime"/> for filters</param>
        /// <param name="queueId">Queue ID specified by Riot League of Legends Queue IDs</param>
        /// <param name="type">Type of League of Legends match (normals, ranked, etc.)</param>
        /// <param name="start">Start entry count index</param>
        /// <param name="count">End entry count index (up to 100 entries)</param>
        /// <returns>An array of <see cref="string"/>s, each string is one League of Legends Match ID</returns>
        /// <exception cref="ArgumentNullException">When Riot Account PUUID is null or empty</exception>
        /// <exception cref="ArgumentOutOfRangeException">When queue ID, start value, count value is less than 0 or when count value is more than 100</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<string[]> GetMatchesForPlayerByPuuidAsync(RiotRegion region, string puuid, DateTime startTime, DateTime endTime, int queueId, LeagueMatchType type, int start, int count)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));
            if (start < 0)
                throw new ArgumentOutOfRangeException(nameof(start), start, "Start value cannot be less than zero");
            if (count < 0 || count > 100)
                throw new ArgumentOutOfRangeException(nameof(count), count, "Start value cannot be less than zero or more than 100");
            if (queueId < 0)
                throw new ArgumentOutOfRangeException(nameof(queueId), queueId, "Queue ID cannot be less than zero");

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-puuid/", puuid, "ids"));

            IDictionary<string, object> queryParams = new Dictionary<string, object>()
            {
                { "startTime", startTime.ToUnixTimeSeconds() },
                { "endTime", endTime.ToUnixTimeSeconds() },
                { "queue", queueId },
                { "type", type.GetLeagueMatchTypeString() },
                { "start", start },
                { "count", count }
            };

            string[] matchIds = await Client.GetAsync<string[]>(endpoint, queryParams);
            return matchIds;
        }

        /// <inheritdoc cref="GetMatchesForPlayerByPuuidAsync(RiotRegion,string,DateTime,DateTime,int,LeagueMatchType,int,int)"/>
        public async Task<string[]> GetMatchesForPlayerByPuuidAsync(RiotRegion region, string puuid, DateTime startTime,
            DateTime endTime, int queueId, LeagueMatchType type)
        {
            return await GetMatchesForPlayerByPuuidAsync(region, puuid, startTime, endTime, queueId, type, 0, 20);
        }

        /// <inheritdoc cref="GetMatchesForPlayerByPuuidAsync(RiotRegion,string,DateTime,DateTime,int,LeagueMatchType,int,int)"/>
        public async Task<string[]> GetMatchesForPlayerByPuuidAsync(RiotRegion region, string puuid, int queueId,
            LeagueMatchType type)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));
            if (queueId < 0)
                throw new ArgumentOutOfRangeException(nameof(queueId), queueId, "Queue ID cannot be less than zero");

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-puuid/", puuid, "ids"));

            IDictionary<string, object> queryParams = new Dictionary<string, object>()
            {
                { "queue", queueId },
                { "type", type.GetLeagueMatchTypeString() }
            };

            string[] matchIds = await Client.GetAsync<string[]>(endpoint, queryParams);
            return matchIds;
        }
        
        /// <inheritdoc cref="GetMatchesForPlayerByPuuidAsync(RiotRegion,string,DateTime,DateTime,int,LeagueMatchType,int,int)"/>
        public async Task<string[]> GetMatchesForPlayerByPuuidAsync(RiotRegion region, string puuid, int queueId)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));
            if (queueId < 0)
                throw new ArgumentOutOfRangeException(nameof(queueId), queueId, "Queue ID cannot be less than zero");

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-puuid/", puuid, "ids"));

            IDictionary<string, object> queryParams = new Dictionary<string, object>()
            {
                { "queue", queueId },
            };

            string[] matchIds = await Client.GetAsync<string[]>(endpoint, queryParams);
            return matchIds;
        }
        
        /// <inheritdoc cref="GetMatchesForPlayerByPuuidAsync(RiotRegion,string,DateTime,DateTime,int,LeagueMatchType,int,int)"/>
        public async Task<string[]> GetMatchesForPlayerByPuuidAsync(RiotRegion region, string puuid,
            LeagueMatchType type)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-puuid/", puuid, "ids"));

            IDictionary<string, object> queryParams = new Dictionary<string, object>()
            {
                { "type", type.GetLeagueMatchTypeString() }
            };

            string[] matchIds = await Client.GetAsync<string[]>(endpoint, queryParams);
            return matchIds;
        }
        
        /// <inheritdoc cref="GetMatchesForPlayerByPuuidAsync(RiotRegion,string,DateTime,DateTime,int,LeagueMatchType,int,int)"/>
        public async Task<string[]> GetMatchesForPlayerByPuuidAsync(RiotRegion region, string puuid, DateTime startTime,
            DateTime endTime)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-puuid/", puuid, "ids"));

            IDictionary<string, object> queryParams = new Dictionary<string, object>()
            {
                { "startTime", startTime.ToUnixTimeSeconds() },
                { "endTime", endTime.ToUnixTimeSeconds() }
            };

            string[] matchIds = await Client.GetAsync<string[]>(endpoint, queryParams);
            return matchIds;
        }
        
        /// <inheritdoc cref="GetMatchesForPlayerByPuuidAsync(RiotRegion,string,DateTime,DateTime,int,LeagueMatchType,int,int)"/>
        public async Task<string[]> GetMatchesForPlayerByPuuidAsync(RiotRegion region, string puuid, DateTime startTime,
            DateTime endTime, int queueId)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));
            if (queueId < 0)
                throw new ArgumentOutOfRangeException(nameof(queueId), queueId, "Queue ID cannot be less than zero");

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-puuid/", puuid, "ids"));

            IDictionary<string, object> queryParams = new Dictionary<string, object>()
            {
                { "startTime", startTime.ToUnixTimeSeconds() },
                { "endTime", endTime.ToUnixTimeSeconds() },
                { "queue", queueId }
            };

            string[] matchIds = await Client.GetAsync<string[]>(endpoint, queryParams);
            return matchIds;
        }
        
        /// <inheritdoc cref="GetMatchesForPlayerByPuuidAsync(RiotRegion,string,DateTime,DateTime,int,LeagueMatchType,int,int)"/>
        public async Task<string[]> GetMatchesForPlayerByPuuidAsync(RiotRegion region, string puuid, DateTime startTime,
            DateTime endTime, LeagueMatchType type)
        {
            
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-puuid/", puuid, "ids"));

            IDictionary<string, object> queryParams = new Dictionary<string, object>()
            {
                { "startTime", startTime.ToUnixTimeSeconds() },
                { "endTime", endTime.ToUnixTimeSeconds() },
                { "type", type.GetLeagueMatchTypeString() },
            };

            string[] matchIds = await Client.GetAsync<string[]>(endpoint, queryParams);
            return matchIds;
        }

        /// <summary>
        /// Gets a League of Legends match information by match ID
        /// </summary>
        /// <param name="region">Riot Data region</param>
        /// <param name="matchId">League of Legends match ID</param>
        /// <returns>An information about match with specified ID</returns>
        /// <exception cref="ArgumentNullException">When match ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        /// <remarks>
        ///  Americas Data region serves: NA, BR, LAN, LAS <br/>
        ///  Asia Data region serves: KR, JP <br/>
        ///  Europe Data region serves: EUNE, EUW, TR, RU <br/>
        ///  Sea Data region serves: OCE
        /// </remarks>
        public async Task<LeagueMatch> GetMatchByIdAsync(RiotRegion region, string matchId)
        {
            if (string.IsNullOrWhiteSpace(matchId))
                throw new ArgumentNullException(nameof(matchId));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, matchId));

            LeagueMatch match = await Client.GetAsync<LeagueMatch>(endpoint, null);
            return match;
        }
    }
}
