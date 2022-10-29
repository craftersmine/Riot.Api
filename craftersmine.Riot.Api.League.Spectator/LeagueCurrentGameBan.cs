using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Spectator
{
    /// <summary>
    /// Represents a League of Legends current game champion ban
    /// </summary>
    public class LeagueCurrentGameBan
    {
        /// <summary>
        /// Gets a banned champion ID in current game
        /// </summary>
        [JsonProperty("championId")]
        public int ChampionId { get; private set; }
        /// <summary>
        /// Gets a team ID that performed that ban in current game
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; private set; }
        /// <summary>
        /// Gets a pick turn number when this ban was performed
        /// </summary>
        [JsonProperty("pickTurn")]
        public int PickTurn { get; private set; }
    }
}
