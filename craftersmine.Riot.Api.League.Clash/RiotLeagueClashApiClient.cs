using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.Clash
{
    /// <summary>
    /// Represents Riot League of Legends Clash v1 API
    /// </summary>
    public class RiotLeagueClashApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lol/clash/v1/";

        /// <summary>
        /// Creates a new instance of <see cref="RiotLeagueClashApiClient"/> instance
        /// </summary>
        /// <param name="settings">Settings for <see cref="RiotLeagueClashApiClient"/></param>
        public RiotLeagueClashApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets a list of Clash players for specified summoner by summoner ID in all registered tournaments
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="summonerId">League of Legends summoner ID</param>
        /// <returns>An <see cref="LeagueClashPlayer"/> array of all players that registered in all tournaments</returns>
        /// <exception cref="ArgumentNullException">When summoner ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueClashPlayer[]> GetClashPlayersBySummonerIdAsync(RiotPlatform region, string summonerId)
        {
            if (string.IsNullOrWhiteSpace(summonerId))
                throw new ArgumentNullException(nameof(summonerId));

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "/players/by-summoner/", summonerId));

            LeagueClashPlayer[] players = await Client.Get<LeagueClashPlayer[]>(endpoint, null);
            return players;
        }

        /// <summary>
        /// Gets a Clash team by team ID
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="teamId">League of Legends Clash team ID</param>
        /// <returns>A <see cref="LeagueClashTeam"/> by specified team ID</returns>
        /// <exception cref="ArgumentNullException">When team ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueClashTeam> GetClashTeamById(RiotPlatform region, string teamId)
        {
            if (string.IsNullOrWhiteSpace(teamId))
                throw new ArgumentNullException(nameof(teamId));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "teams", teamId));

            LeagueClashTeam team = await Client.Get<LeagueClashTeam>(endpoint, null);
            return team;
        }
    }
}
