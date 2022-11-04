using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.Runeterra.Matches
{
    /// <summary>
    /// Represents a Legends of Runeterra match player information
    /// </summary>
    public class RuneterraMatchPlayer
    {
        /// <summary>
        /// Gets an order in which this player played
        /// </summary>
        [JsonProperty("order_of_play")]
        public int OrderOfPlay { get; private set; }
        /// <summary>
        /// Gets a Riot Account PUUID of this player
        /// </summary>
        [JsonProperty("puuid")]
        public string Puuid { get; private set; }
        /// <summary>
        /// Gets a player's deck code
        /// </summary>
        [JsonProperty("deck_code")]
        public string DeckCode { get; private set; }
        /// <summary>
        /// Gets a player's deck factions
        /// </summary>
        [JsonProperty("factions")]
        public string[] Factions { get; private set; }
        /// <summary>
        /// Gets a player's deck ID
        /// </summary>
        [JsonProperty("deck_id")]
        public Guid DeckId { get; private set; }
        /// <summary>
        /// Gets a player's game outcome
        /// </summary>
        [JsonProperty("game_outcome"), JsonConverter(typeof(StringEnumConverter))]
        public RuneterraGameOutcome GameOutcome { get; private set; }
    }
}
