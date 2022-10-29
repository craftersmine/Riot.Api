using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;
using craftersmine.Riot.Api.League.SummonerLeagues;

namespace craftersmine.Riot.Api.Tft.Leagues
{
    /// <summary>
    /// Represents a Riot Teamfight Tactics Leagues v1 API
    /// </summary>
    public class RiotTftLeaguesApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/tft/league/v1/";

        /// <summary>
        /// Creates a new instance of <see cref="RiotTftLeaguesApiClient"/> instance
        /// </summary>
        /// <param name="settings">Settings for <see cref="RiotTftLeaguesApiClient"/></param>
        public RiotTftLeaguesApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets Teamfight Tactics Challenger League in specified region
        /// </summary>
        /// <param name="region">Teamfight Tactics server region</param>
        /// <returns><see cref="TftLeagueList"/> for challenger leagues in specified region</returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<TftLeagueList> GetChallengerLeagueAsync(RiotPlatform region)
        {
            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "challenger"));

            TftLeagueList leagueList = await Client.Get<TftLeagueList>(endpoint, null);
            return leagueList;
        }

        /// <summary>
        /// Gets Teamfight Tactics Grandmaster League in specified region
        /// </summary>
        /// <param name="region">Teamfight Tactics server region</param>
        /// <returns><see cref="TftLeagueList"/> for grandmaster leagues in specified region</returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<TftLeagueList> GetGrandmasterLeagueAsync(RiotPlatform region)
        {
            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "grandmaster"));

            TftLeagueList leagueList = await Client.Get<TftLeagueList>(endpoint, null);
            return leagueList;
        }

        /// <summary>
        /// Gets Teamfight Tactics Master League in specified region
        /// </summary>
        /// <param name="region">Teamfight Tactics server region</param>
        /// <returns><see cref="TftLeagueList"/> for master leagues in specified region</returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<TftLeagueList> GetMasterLeagueAsync(RiotPlatform region)
        {
            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "master"));

            TftLeagueList leagueList = await Client.Get<TftLeagueList>(endpoint, null);
            return leagueList;
        }

        /// <summary>
        /// Gets Teamfight Tactics League entries for summoner by summoner ID in specified region
        /// </summary>
        /// <param name="region">Teamfight Tactics server region</param>
        /// <param name="summonerId">Teamfight Tactics summoner ID</param>
        /// <returns>An array of <see cref="TftSummonerLeague"/> for specified summoner</returns>
        /// <exception cref="ArgumentNullException">When summoner ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<TftSummonerLeague[]> GetLeagueEntriesForSummonerByIdAsync(RiotPlatform region, string summonerId)
        {
            if (string.IsNullOrWhiteSpace(summonerId))
                throw new ArgumentNullException(nameof(summonerId));

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-summoner", summonerId));

            TftSummonerLeague[] summonerLeagues = await Client.Get<TftSummonerLeague[]>(endpoint, null);
            return summonerLeagues;
        }

        /// <summary>
        /// Gets a Teamfight Tactics League entries for specified rank tier, division rank in specified region
        /// </summary>
        /// <param name="region">Teamfight Tactics server region</param>
        /// <param name="rankedTier">Teamfight Tactics ranked tier</param>
        /// <param name="divisionRank">Teamfight Tactics ranked division</param>
        /// <param name="page">Number of page for fetching data</param>
        /// <returns>An array of <see cref="TftSummonerLeague"/> for specified data</returns>
        /// <exception cref="ArgumentOutOfRangeException">When page number is less than 1</exception>
        /// <exception cref="ArgumentException">When ranked tier is unranked or unknown or division rank is unknown</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<TftSummonerLeague[]> GetLeagueEntriesAsync(RiotPlatform region, LeagueRankedTier rankedTier,
            LeagueDivisionRank divisionRank, int page)
        {
            if (page < 1)
                throw new ArgumentOutOfRangeException(nameof(page), "Page number cannot be less than 1");
            if (rankedTier == LeagueRankedTier.Unknown || rankedTier == LeagueRankedTier.Unranked)
                throw new ArgumentException("Unknown or unranked tier selected!", nameof(rankedTier));
            if (divisionRank == LeagueDivisionRank.Unknown)
                throw new ArgumentException("Unknown division is selected!", nameof(divisionRank));

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "entries", rankedTier.GetRankedTierString(),
                    divisionRank.GetLeagueDivisionRankString()));

            TftSummonerLeague[] summonerLeagues = await Client.Get<TftSummonerLeague[]>(endpoint, new Dictionary<string, object>() { { "page", page } });
            return summonerLeagues;
        }

        /// <inheritdoc cref="GetLeagueEntriesAsync(RiotPlatform,LeagueRankedTier,LeagueDivisionRank,int)"/>
        public async Task<TftSummonerLeague[]> GetLeagueEntriesAsync(RiotPlatform region, LeagueRankedTier rankedTier,
            LeagueDivisionRank divisionRank)
        {
            return await GetLeagueEntriesAsync(region, rankedTier, divisionRank, 1);
        }

        /// <summary>
        /// Gets Teamfight Tactics League entries by specified League ID in specified region
        /// </summary>
        /// <param name="region">Teamfight Tactics server region</param>
        /// <param name="leagueId">Teamfight Tactics League ID</param>
        /// <returns><see cref="TftLeagueList"/> for specified Teamfight Tactics League ID</returns>
        /// <exception cref="ArgumentNullException">When league ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<TftLeagueList> GetLeagueEntriesByLeagueIdAsync(RiotPlatform region, string leagueId)
        {
            if (string.IsNullOrWhiteSpace(leagueId))
                throw new ArgumentNullException(nameof(leagueId));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "leagues", leagueId));

            TftLeagueList leagueList = await Client.Get<TftLeagueList>(endpoint, null);
            return leagueList;
        }

        /// <summary>
        /// Gets a Teamfight Tactics Hyper Roll top rated ladder entries for specified region
        /// </summary>
        /// <param name="region">Teamfight Tactics server region</param>
        /// <returns>An array of <see cref="TftHyperRollTopRatedLadderEntry"/> for specified region</returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<TftHyperRollTopRatedLadderEntry[]> GetHyperRollTopRatedLadderAsync(RiotPlatform region)
        {
            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "RANKED_TFT_TURBO/top"));

            TftHyperRollTopRatedLadderEntry[] topRatedLadderEntries = await Client.Get<TftHyperRollTopRatedLadderEntry[]>(endpoint, null);
            return topRatedLadderEntries;
        }
    }
}
