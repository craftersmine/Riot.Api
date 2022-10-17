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
        /// Gets a Clash team by team ID in specified region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="teamId">League of Legends Clash team ID</param>
        /// <returns>A <see cref="LeagueClashTeam"/> by specified team ID</returns>
        /// <exception cref="ArgumentNullException">When team ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueClashTeam> GetClashTeamByIdAsync(RiotPlatform region, string teamId)
        {
            if (string.IsNullOrWhiteSpace(teamId))
                throw new ArgumentNullException(nameof(teamId));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "teams", teamId));

            LeagueClashTeam team = await Client.Get<LeagueClashTeam>(endpoint, null);
            return team;
        }

        /// <summary>
        /// Gets active and upcoming Clash Tournaments for specified region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <returns>An array of <see cref="LeagueClashTournament"/></returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueClashTournament[]> GetClashTournamentsAsync(RiotPlatform region)
        {
            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "tournaments"));

            LeagueClashTournament[] tournaments = await Client.Get<LeagueClashTournament[]>(endpoint, null);
            return tournaments;
        }

        /// <summary>
        /// Gets current Clash tournament for team with specified ID in specified region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="teamId">Clash Team ID</param>
        /// <returns><see cref="LeagueClashTournament"/> for specified team</returns>
        /// <exception cref="ArgumentNullException">When team ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueClashTournament> GetClashTournamentByTeamIdAsync(RiotPlatform region, string teamId)
        {
            if (string.IsNullOrWhiteSpace(teamId))
                throw new ArgumentNullException(nameof(teamId));

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "tournaments/by-team", teamId));

            LeagueClashTournament tournament = await Client.Get<LeagueClashTournament>(endpoint, null);
            return tournament;
        }

        /// <summary>
        /// Gets a Clash Tournament by Tournament ID in specified region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="tournamentId">Clash Tournament ID</param>
        /// <returns><see cref="LeagueClashTournament"/> with specified tournament ID</returns>
        /// <exception cref="ArgumentOutOfRangeException">When tournament ID is less than 0</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueClashTournament> GetClashTournamentByIdAsync(RiotPlatform region, int tournamentId)
        {
            if (tournamentId < 0)
                throw new ArgumentOutOfRangeException(nameof(tournamentId), "Tournament ID cannot be less than 0");

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "tournaments", tournamentId.ToString()));

            LeagueClashTournament tournament = await Client.Get<LeagueClashTournament>(endpoint, null);
            return tournament;
        }
    }
}
