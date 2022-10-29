using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tft.Matches
{
    /// <summary>
    /// Represents a Teamfight Tactics match
    /// </summary>
    public class TftMatch
    {
        /// <summary>
        /// Gets a Teamfight Tactics match metadata
        /// </summary>
        [JsonProperty("metadata")]
        public TftMatchMetadata Metadata { get; private set; }
        /// <summary>
        /// Gets a Teamfight Tactics match information
        /// </summary>
        [JsonProperty("info")]
        public TftMatchInfo MatchInfo { get; private set; }
    }
}
