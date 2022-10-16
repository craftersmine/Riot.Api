using System;
using craftersmine.Riot.Api.Common;

namespace craftersmine.Riot.Api.League.Mastery
{
    /// <summary>
    /// Represents a Riot Champion-Mastery v4 API
    /// </summary>
    public class RiotLeagueMasteryApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lol/champion-mastery/v4/";

        /// <summary>
        /// Creates a new instance of <see cref="RiotLeagueMasteryApiClient"/> instance
        /// </summary>
        /// <param name="settings">Settings for <see cref="RiotLeagueMasteryApiClient"/></param>
        public RiotLeagueMasteryApiClient(RiotApiClientSettings settings) : base(settings) { }


    }
}
