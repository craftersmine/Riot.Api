using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Runeterra.Ranked
{
    /// <summary>
    /// Represents a Legends of Runeterra Player
    /// </summary>
    public class RuneterraPlayer
    {
        /// <summary>
        /// Gets player's rank
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; private set; }
        /// <summary>
        /// Gets player's earned amount of League Points
        /// </summary>
        [JsonProperty("lp")]
        public int LeaguePoints { get; private set; }
        /// <summary>
        /// Gets player's name in game
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
    }
}
