using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends match ban
    /// </summary>
    public class LeagueMatchBan
    {
        /// <summary>
        /// Gets a League of Legends champion ID
        /// </summary>
        [JsonProperty("championId")]
        public int ChampionId { get; private set; }
        /// <summary>
        /// Gets a ban pick turn
        /// </summary>
        [JsonProperty("pickTurn")]
        public int PickTurn { get; private set; }
    }
}
