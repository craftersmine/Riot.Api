using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tft.Matches
{
    /// <summary>
    /// Represents a Teamfight Tactics match metadata
    /// </summary>
    public class TftMatchMetadata
    {
        /// <summary>
        /// Gets current data version of match info
        /// </summary>
        [JsonProperty("data_version")]
        public int DataVersion { get; private set; }
        /// <summary>
        /// Gets Teamfight Tactics match ID
        /// </summary>
        [JsonProperty("match_id")]
        public string MatchId { get; private set; }
        /// <summary>
        /// Gets an array of <see langword="string"/> of Teamfight Tactics participant PUUIDs
        /// </summary>
        [JsonProperty("participants")]
        public string[] ParticipantIds { get; private set; }
    }
}
