using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a information about current League match
    /// </summary>
    public class LeagueGameData
    {
        /// <summary>
        /// Gets information about current player
        /// </summary>
        /// <remarks>
        /// Values will be null or empty if you requesting data about game you spectating
        /// </remarks>
        [JsonProperty("activePlayer")]
        public LeagueActivePlayerData ActivePlayer { get; private set; }
        /// <summary>
        /// Gets information about current players
        /// </summary>
        [JsonProperty("allPlayers")]
        public LeaguePlayerData[] Players { get; private set; }
        /// <summary>
        /// Gets information about occurred game events
        /// </summary>
        [JsonProperty("events")]
        public LeagueGameEvents Events { get; private set; }
        /// <summary>
        /// Gets metadata information about match
        /// </summary>
        [JsonProperty("gameData")]
        public LeagueGameMetadata GameData { get; private set; }
    }
}
