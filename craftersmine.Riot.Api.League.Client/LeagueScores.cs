using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends player scores
    /// </summary>
    public class LeagueScores
    {
        /// <summary>
        /// Gets an amount of assists made by player
        /// </summary>
        [JsonProperty("assists")]
        public int Assists { get; private set; }
        /// <summary>
        /// Gets an amount of minions and jungle monsters killed by player (CS)
        /// </summary>
        [JsonProperty("creepScore")]
        public int CreepScore { get; private set; }
        /// <summary>
        /// Gets an amount of deaths of this player
        /// </summary>
        [JsonProperty("deaths")]
        public int Deaths { get; private set; }
        /// <summary>
        /// Gets an amount of kills made by player
        /// </summary>
        [JsonProperty("kills")]
        public int Kills { get; private set; }
        /// <summary>
        /// Gets a player's current vision score
        /// </summary>
        [JsonProperty("wardScore")]
        public double VisionScore { get; private set; }
    }
}
