using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Tournament
{
    /// <summary>
    /// Represents a League of Legends Tournament provider registration parameters
    /// </summary>
    public class LeagueTournamentProviderRegistrationParameters
    {
        /// <summary>
        /// Gets or sets a Tournament provider region
        /// </summary>
        [JsonProperty("region"), JsonConverter(typeof(RiotPlatformAsLeagueRegionConverter), true)]
        public RiotPlatform Region { get; set; }
        /// <summary>
        /// Gets or sets a Tournament provider URL
        /// </summary>
        [JsonProperty("url")]
        public string ProviderUrl { get; set; }

        /// <summary>
        /// Creates a new instance of <see cref="LeagueTournamentProviderRegistrationParameters"/>
        /// </summary>
        /// <param name="region">Tournament provider region</param>
        /// <param name="providerUrl">Tournament provider URL</param>
        public LeagueTournamentProviderRegistrationParameters(RiotPlatform region, string providerUrl)
        {
            Region = region;
            ProviderUrl = providerUrl;
        }
    }
}
