﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends Match metadata
    /// </summary>
    public class LeagueMatchMetadata
    {
        /// <summary>
        /// Gets a League of Legends game version on which this match was played
        /// </summary>
        [JsonProperty("gameVersion")]
        public string GameVersion { get; private set; }
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
