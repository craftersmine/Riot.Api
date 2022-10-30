using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.Mastery
{
    /// <summary>
    /// Represents a Riot Champion-Mastery v4 API
    /// </summary>
    public class LeagueMasteryApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lol/champion-mastery/v4/";

        /// <summary>
        /// Creates a new instance of <see cref="LeagueMasteryApiClient"/> instance
        /// </summary>
        /// <param name="settings">Settings for <see cref="LeagueMasteryApiClient"/></param>
        public LeagueMasteryApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets all champion masteries existing on champions for League of Legends summoner by League of Legends summoner ID
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="summonerId">League of Legends summoner ID</param>
        /// <returns>Array of <see cref="LeagueChampionMastery"/> with all ever earned masteries for summoner</returns>
        /// <exception cref="ArgumentNullException">When summoner ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueChampionMastery[]> GetMasteriesBySummonerId(RiotPlatform region, string summonerId)
        {
            if (string.IsNullOrWhiteSpace(summonerId))
                throw new ArgumentNullException(nameof(summonerId));

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "champion-masteries/by-summoner", summonerId));

            LeagueChampionMastery[] masteries = await Client.Get<LeagueChampionMastery[]>(endpoint, null);
            return masteries;
        }

        /// <summary>
        /// Gets a mastery information for specified League of Legends champion for specified summoner by summoner ID
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="championId">League of Legends champion ID</param>
        /// <param name="summonerId">League of Legends summoner ID</param>
        /// <returns><see cref="LeagueChampionMastery"/> for specified champion on specified summoner</returns>
        /// <exception cref="ArgumentOutOfRangeException">When champion ID is less than 1</exception>
        /// <exception cref="ArgumentNullException">When summoner ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueChampionMastery> GetMasteryForChampionBySummonerId(RiotPlatform region, int championId,
            string summonerId)
        {
            if (championId < 1)
                throw new ArgumentOutOfRangeException(nameof(championId), "Champion ID cannot be less than 1");

            if (string.IsNullOrWhiteSpace(summonerId))
                throw new ArgumentNullException(nameof(summonerId));

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "champion-masteries/by-summoner/", summonerId, "/by-champion/",
                    championId.ToString()));

            LeagueChampionMastery mastery = await Client.Get<LeagueChampionMastery>(endpoint, null);
            return mastery;
        }

        /// <summary>
        /// Gets a specified top champion masteries for specified summoner by summoner ID
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="summonerId">League of Legends summoner ID</param>
        /// <param name="topEntriesCount">Count of mastery entries for top</param>
        /// <returns>An array of top count of <see cref="LeagueChampionMastery"/></returns>
        /// <exception cref="ArgumentOutOfRangeException">When top count is less than 1</exception>
        /// <exception cref="ArgumentNullException">When summoner ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueChampionMastery[]> GetTopMasteriesBySummonerId(RiotPlatform region, string summonerId,
            int topEntriesCount)
        {
            if (topEntriesCount < 1)
                throw new ArgumentOutOfRangeException(nameof(topEntriesCount),
                    "Top entries count cannot be less than 1");
            if (string.IsNullOrWhiteSpace(summonerId))
                throw new ArgumentNullException(nameof(summonerId));

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "champion-masteries/by-summoner/", summonerId, "/top"));

            LeagueChampionMastery[] topMasteries = await Client.Get<LeagueChampionMastery[]>(endpoint,
                new Dictionary<string, object>() {{"count", topEntriesCount}});
            return topMasteries;
        }

        /// <summary>
        /// Gets a specified top 3 champion masteries for specified summoner by summoner ID
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="summonerId">League of Legends summoner ID</param>
        /// <returns>An array of top count of <see cref="LeagueChampionMastery"/></returns>
        /// <exception cref="ArgumentNullException">When summoner ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueChampionMastery[]> GetTopThreeMasteriesBySummonerId(RiotPlatform region,
            string summonerId)
        {
            return await GetTopMasteriesBySummonerId(region, summonerId, 3);
        }

        /// <summary>
        /// Gets total number of masteries on all champions for specified summoner by summoner ID
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="summonerId">League of Legends summoner ID</param>
        /// <returns><see cref="int"/> of total earned masteries on all champions</returns>
        /// <exception cref="ArgumentNullException">When summoner ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<int> GetTotalMasteriesBySummonerId(RiotPlatform region, string summonerId)
        {
            if (string.IsNullOrWhiteSpace(summonerId))
                throw new ArgumentNullException(nameof(summonerId));

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "scores/by-summoner", summonerId));

            int totalMasteries = await Client.Get<int>(endpoint, null);
            return totalMasteries;
        }
    }
}
