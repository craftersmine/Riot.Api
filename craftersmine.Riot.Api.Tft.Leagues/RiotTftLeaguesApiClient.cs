using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;
using craftersmine.Riot.Api.League.SummonerLeagues;

namespace craftersmine.Riot.Api.Tft.Leagues
{
    public class RiotTftLeaguesApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/tft/league/v1/";

        public RiotTftLeaguesApiClient(RiotApiClientSettings settings) : base(settings) { }

        public async Task<TftLeagueList> GetChallengerLeagueAsync(RiotPlatform region)
        {
            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "challenger"));

            TftLeagueList leagueList = await Client.Get<TftLeagueList>(endpoint, null);
            return leagueList;
        }

        public async Task<TftLeagueList> GetGrandmasterLeagueAsync(RiotPlatform region)
        {
            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "grandmaster"));

            TftLeagueList leagueList = await Client.Get<TftLeagueList>(endpoint, null);
            return leagueList;
        }

        public async Task<TftLeagueList> GetMasterLeagueAsync(RiotPlatform region)
        {
            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "master"));

            TftLeagueList leagueList = await Client.Get<TftLeagueList>(endpoint, null);
            return leagueList;
        }

        public async Task<TftSummonerLeague[]> GetLeagueEntriesForSummonerByIdAsync(RiotPlatform region, string summonerId)
        {
            if (string.IsNullOrWhiteSpace(summonerId))
                throw new ArgumentNullException(nameof(summonerId));

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-summoner", summonerId));

            TftSummonerLeague[] summonerLeagues = await Client.Get<TftSummonerLeague[]>(endpoint, null);
            return summonerLeagues;
        }

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

        public async Task<TftSummonerLeague[]> GetLeagueEntriesAsync(RiotPlatform region, LeagueRankedTier rankedTier,
            LeagueDivisionRank divisionRank)
        {
            return await GetLeagueEntriesAsync(region, rankedTier, divisionRank, 1);
        }

        public async Task<TftLeagueList> GetLeagueEntriesByLeagueIdAsync(RiotPlatform region, string leagueId)
        {
            if (string.IsNullOrWhiteSpace(leagueId))
                throw new ArgumentNullException(nameof(leagueId));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "leagues", leagueId));

            TftLeagueList leagueList = await Client.Get<TftLeagueList>(endpoint, null);
            return leagueList;
        }

        public async Task<TftHyperRollTopRatedLadderEntry[]> GetHyperRollTopRatedLadderAsync(RiotPlatform region)
        {
            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "RANKED_TFT_TURBO/top"));

            TftHyperRollTopRatedLadderEntry[] topRatedLadderEntries = await Client.Get<TftHyperRollTopRatedLadderEntry[]>(endpoint, null);
            return topRatedLadderEntries;
        }
    }
}
