using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.Matches.Timeline
{
    /// <summary>
    /// Represents a Riot Match v5 Timeline API
    /// </summary>
    public class LeagueMatchTimelineApiClient : LeagueMatchApiClient
    {
        /// <summary>
        /// Creates a new instance of <see cref="LeagueMatchTimelineApiClient"/> instance
        /// </summary>
        /// <param name="settings">Settings for <see cref="LeagueMatchApiClient"/></param>
        public LeagueMatchTimelineApiClient(RiotApiClientSettings settings) : base(settings)
        { }

        /// <summary>
        /// Gets a League of Legends match timeline information by match ID in specified region
        /// </summary>
        /// <remarks>
        ///  Americas Data region serves: NA, BR, LAN, LAS <br/>
        ///  Asia Data region serves: KR, JP <br/>
        ///  Europe Data region serves: EUNE, EUW, TR, RU <br/>
        ///  Sea Data region serves: OCE
        /// </remarks>
        /// <param name="region">Riot Data Region</param>
        /// <param name="matchId">League of Legends match ID</param>
        /// <returns>A timeline of match with specified ID</returns>
        /// <exception cref="ArgumentNullException">When match ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueMatchTimeline> GetMatchTimelineByMatchIdAsync(RiotRegion region, string matchId)
        {
            if (string.IsNullOrWhiteSpace(matchId))
                throw new ArgumentNullException(nameof(matchId));

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, matchId, "/timeline"));

            LeagueMatchTimeline timeline = await Client.GetAsync<LeagueMatchTimeline>(endpoint, null);
            return timeline;
        }
    }
}
