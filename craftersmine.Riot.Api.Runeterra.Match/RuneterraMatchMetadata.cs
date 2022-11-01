using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Runeterra.Matches
{
    /// <summary>
    /// Represents a Legends of Runeterra match metadata
    /// </summary>
    public class RuneterraMatchMetadata
    {
        /// <summary>
        /// Gets a Legends or Runeterra match info data version
        /// </summary>
        [JsonProperty("data_version")]
        public int DataVersion { get; private set; }
        /// <summary>
        /// Gets a Legends of Runeterra match ID
        /// </summary>
        [JsonProperty("match_id")]
        public Guid MatchId { get; private set; }
        /// <summary>
        /// Gets an array of participant's Riot Account PUUIDs that participated in that match
        /// </summary>
        [JsonProperty("participants")]
        public string[] Participants { get; private set; }
    }
}
