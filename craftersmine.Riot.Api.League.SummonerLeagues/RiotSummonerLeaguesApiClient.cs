using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.SummonerLeagues
{
    /// <summary>
    /// Represents a Riot League v4 API
    /// </summary>
    public class RiotSummonerLeaguesApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lol/league/v4/";

        /// <summary>
        /// Creates a new instance of <see cref="RiotSummonerLeaguesApiClient"/> instance
        /// </summary>
        /// <param name="settings">Settings for <see cref="RiotSummonerLeaguesApiClient"/></param>
        public RiotSummonerLeaguesApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets Ranked League of Legends entries for summoner with summoner ID from specified region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="summonerId">League of Legends summoner ID</param>
        /// <returns>An array of Ranked Leagues for summoner</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<SummonerLeague[]> GetLeagueEntriesForSummonerByIdAsync(RiotPlatform region, string summonerId)
        {
            if (string.IsNullOrWhiteSpace(summonerId))
                throw new ArgumentNullException(nameof(summonerId));

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "entries/by-summoner", summonerId));

            SummonerLeague[] leagues = await Client.Get<SummonerLeague[]>(endpoint, null);
            return leagues;
        }

        /// <summary>
        /// Gets a League of Legends Challenger League by specified queue in specified region 
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="queue">League of Legends ranked queue type</param>
        /// <returns><see cref="LeagueList"/> of League and summoner entries</returns>
        /// <exception cref="ArgumentException">When unknown queue selected</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueList> GetChallengerLeaguesByQueueAsync(RiotPlatform region, LeagueQueueType queue)
        {
            if (queue == LeagueQueueType.Unknown)
                throw new ArgumentException("Queue cannot be Unknown!", nameof(queue));

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "challengerleagues/by-queue", queue.GetLeagueQueueStringFor()));

            LeagueList leagueList = await Client.Get<LeagueList>(endpoint, null);
            return leagueList;
        }
        
        /// <summary>
        /// Gets a League of Legends Grandmaster League by specified queue in specified region 
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="queue">League of Legends ranked queue type</param>
        /// <returns><see cref="LeagueList"/> of League and summoner entries</returns>
        /// <exception cref="ArgumentException">When unknown queue selected</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueList> GetGrandmasterLeaguesByQueueAsync(RiotPlatform region, LeagueQueueType queue)
        {
            if (queue == LeagueQueueType.Unknown)
                throw new ArgumentException("Queue cannot be Unknown!", nameof(queue));

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "grandmasterleagues/by-queue", queue.GetLeagueQueueStringFor()));

            LeagueList leagueList = await Client.Get<LeagueList>(endpoint, null);
            return leagueList;
        }

        /// <summary>
        /// Gets a League of Legends Master League by specified queue in specified region 
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="queue">League of Legends ranked queue type</param>
        /// <returns><see cref="LeagueList"/> of League and summoner entries</returns>
        /// <exception cref="ArgumentException">When unknown queue selected</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueList> GetMasterLeaguesByQueueAsync(RiotPlatform region, LeagueQueueType queue)
        {
            if (queue == LeagueQueueType.Unknown)
                throw new ArgumentException("Queue cannot be Unknown!", nameof(queue));

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "masterleagues/by-queue", queue.GetLeagueQueueStringFor()));

            LeagueList leagueList = await Client.Get<LeagueList>(endpoint, null);
            return leagueList;
        }

        /// <summary>
        /// Gets all League of Legends summoners Leagues for specified region, queue, tier and division from specified page
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="queue">League of Legends ranked queue type</param>
        /// <param name="tier">League of Legends ranked tier</param>
        /// <param name="division">League of Legends ranked tier division</param>
        /// <param name="page">Data page</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">When queue, tier or division is set to Unknown</exception>
        /// <exception cref="ArgumentOutOfRangeException">When page is less than 1</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<SummonerLeague[]> GetLeagueEntriesAsync(RiotPlatform region, LeagueQueueType queue,
            LeagueRankedTier tier, LeagueDivisionRank division, int page)
        {
            if (page < 1)
                throw new ArgumentOutOfRangeException(nameof(page), "Page number cannot be less than 1");
            if (queue == LeagueQueueType.Unknown)
                throw new ArgumentException("Selected Unknown queue!", nameof(queue));
            if (tier == LeagueRankedTier.Unknown || tier == LeagueRankedTier.Unranked)
                throw new ArgumentException("Unknown or unranked tier selected!", nameof(tier));
            if (division == LeagueDivisionRank.Unknown)
                throw new ArgumentException("Unknown division is selected!", nameof(division));

            string endpoint = string.Empty;
            if (!Settings.UseExperimentalLeaguesApi)
                endpoint = UriUtils.GetAddress(region,
                    UriUtils.JoinEndpoints(ApiEndpointRoot, "entries", queue.GetLeagueQueueStringFor(),
                        tier.GetRankedTierString(), division.GetLeagueDivisionRankString()));
            else
                endpoint = UriUtils.GetAddress(region,
                    UriUtils.JoinEndpoints("/lol/league-exp/v4/entries", queue.GetLeagueQueueStringFor(),
                        tier.GetRankedTierString(), division.GetLeagueDivisionRankString(), page.ToString()));

            SummonerLeague[] leagues = await Client.Get<SummonerLeague[]>(endpoint, new Dictionary<string, object>(){ { "page", page } });
            return leagues;
        }
        
        /// <summary>
        /// Gets all League of Legends summoners Leagues for specified region, queue, tier and division from first page
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="queue">League of Legends ranked queue type</param>
        /// <param name="tier">League of Legends ranked tier</param>
        /// <param name="division">League of Legends ranked tier division</param>
        /// <exception cref="ArgumentException">When queue, tier or division is set to Unknown</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<SummonerLeague[]> GetLeagueEntriesAsync(RiotPlatform region, LeagueQueueType queue,
            LeagueRankedTier tier, LeagueDivisionRank division)
        {
            return await GetLeagueEntriesAsync(region, queue, tier, division, 1);
        }

        /// <summary>
        /// Gets a League of Legends ranked league by UUID
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="leagueId">League of Legends ranked league UUID</param>
        /// <returns><see cref="LeagueList"/> without inactive entries</returns>
        /// <exception cref="ArgumentNullException">When League ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueList> GetLeagueEntriesByLeagueIdAsync(RiotPlatform region, string leagueId)
        {
            if (string.IsNullOrWhiteSpace(leagueId))
                throw new ArgumentNullException(nameof(leagueId));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "leagues", leagueId));

            LeagueList leagueList = await Client.Get<LeagueList>(endpoint, null);
            return leagueList;
        }
    }
}