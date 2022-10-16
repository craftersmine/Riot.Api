using System;
using craftersmine.Riot.Api.Common;

namespace craftersmine.Riot.Api.League.Clash
{
    /// <summary>
    /// Represents Riot League of Legends Clash v1 API
    /// </summary>
    public class RiotLeagueClashApiClient : RiotApiClient
    {
        /// <summary>
        /// Creates a new instance of <see cref="RiotLeagueClashApiClient"/> instance
        /// </summary>
        /// <param name="settings">Settings for <see cref="RiotLeagueClashApiClient"/></param>
        public RiotLeagueClashApiClient(RiotApiClientSettings settings) : base(settings) { }


    }
}
