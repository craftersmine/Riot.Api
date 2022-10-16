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
        public async Task<SummonerLeague[]> GetLeagueEntriesForSummonerById(RiotPlatform region, string summonerId)
        {
            if (string.IsNullOrWhiteSpace(summonerId))
                throw new ArgumentNullException(nameof(summonerId));

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "entries/by-summoner", summonerId));

            SummonerLeague[] leagues = await Client.Get<SummonerLeague[]>(endpoint, null);
            return leagues;
        }
    }
}