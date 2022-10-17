using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends Match
    /// </summary>
    public class LeagueMatch
    {
        /// <summary>
        /// Gets League of Legends match metadata
        /// </summary>
        [JsonProperty("metadata")]
        public LeagueMatchMetadata Metadata { get; private set; }
        /// <summary>
        /// Gets League of Legends match information
        /// </summary>
        [JsonProperty("info")]
        public LeagueMatchInfo Info { get; private set; }
    }
}
