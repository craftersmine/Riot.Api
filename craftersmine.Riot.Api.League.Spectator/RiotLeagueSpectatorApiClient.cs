using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.Spectator
{
    /// <summary>
    /// Represents a League of Legends Spectator v4 API client
    /// </summary>
    public class RiotLeagueSpectatorApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lol/spectator/v4";
        
        /// <summary>
        /// Creates a new instance of <see cref="RiotLeagueSpectatorApiClient"/> instance
        /// </summary>
        /// <param name="settings">Settings for <see cref="RiotLeagueSpectatorApiClient"/></param>
        public RiotLeagueSpectatorApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets currently playing featured games in specified League of Legends region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <returns><see cref="LeagueCurrentFeaturedGamesInformation"/> with current featured games in specified region</returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueCurrentFeaturedGamesInformation> GetCurrentFeaturedGamesAsync(RiotPlatform region)
        {
            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "featured-games"));

            LeagueCurrentFeaturedGamesInformation featuredGamesInformation =
                await Client.Get<LeagueCurrentFeaturedGamesInformation>(endpoint, null);
            return featuredGamesInformation;
        }

        /// <summary>
        /// Gets current League of Legends game information of summoner by summoner ID
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="summonerId">League of Legends summoner ID</param>
        /// <returns>A <see cref="LeagueCurrentGameInfo"/> if summoner currently playing the game, <br/>
        /// or throws <see cref="Common.Exceptions.RiotApiException"/> with status code 404 if summoner is not currently playing any game</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails or 404 when summoner is not currently participating in any game</exception>
        public async Task<LeagueCurrentGameInfo> GetCurrentGameBySummonerIdAsync(RiotPlatform region, string summonerId)
        {
            if (string.IsNullOrWhiteSpace(summonerId))
                throw new ArgumentNullException(nameof(summonerId));

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "/active-games/by-summoner", summonerId));

            LeagueCurrentGameInfo currentGameInfo = await Client.Get<LeagueCurrentGameInfo>(endpoint, null);
            return currentGameInfo;
        }
    }
}
