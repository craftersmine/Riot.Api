using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.Runeterra.Matches
{
    /// <summary>
    /// Represents a Legends of Runeterra match information
    /// </summary>
    public class RuneterraMatchInfo
    {
        /// <summary>
        /// Gets a total amount of turns that was performed in a game
        /// </summary>
        [JsonProperty("total_turn_count")]
        public int TotalTurnCount { get; private set; }
        /// <summary>
        /// Gets a version of game on which this match was played
        /// </summary>
        [JsonProperty("game_version")]
        public string GameVersion { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> timestamp when this game was started
        /// </summary>
        [JsonProperty("game_start_time_utc"), JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime GameStartTime { get; private set; }
        /// <summary>
        /// Gets a mode of this game
        /// </summary>
        [JsonProperty("game_mode"), JsonConverter(typeof(StringEnumConverter))]
        public RuneterraGameMode GameMode { get; private set; }
        /// <summary>
        /// Gets a type of this game
        /// </summary>
        [JsonProperty("game_type"), JsonConverter(typeof(StringEnumConverter))]
        public RuneterraGameType GameType { get; private set; }
        /// <summary>
        /// Gets a participated players in this game
        /// </summary>
        [JsonProperty("players")]
        public RuneterraMatchPlayer[] Players { get; private set; }
    }
}
