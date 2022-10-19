using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends Match metadata
    /// </summary>
    public class LeagueMatchMetadata
    {
        /// <summary>
        /// Gets a League of Legends match data version that is used for info
        /// </summary>
        [JsonProperty("dataVersion")]
        public int DataVersion { get; private set; }
        /// <summary>
        /// Gets a League of Legends game version on which this match was played
        /// </summary>
        [JsonProperty("gameVersion"), Obsolete("This property isn't returned by server so it could be an empty version"), JsonConverter(typeof(VersionConverter))]
        public Version GameVersion { get; private set; }
        /// <summary>
        /// Gets a League of Legends match ID
        /// </summary>
        [JsonProperty("matchId")]
        public string MatchId { get; private set; }
        /// <summary>
        /// Gets an array of participants Riot Account PUUIDs
        /// </summary>
        [JsonProperty("participants")]
        public string[] Participants { get; private set; }
    }
}
