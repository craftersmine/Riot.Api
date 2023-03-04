using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends current game metadata
    /// </summary>
    public class LeagueGameMetadata
    {
        /// <summary>
        /// Gets an map ID
        /// </summary>
        [JsonProperty("mapNumber")]
        public int MapId { get; private set; }
        /// <summary>
        /// Gets a name of game mode
        /// </summary>
        [JsonProperty("gameMode")]
        public string GameMode { get; private set; }
        /// <summary>
        /// Gets an internal map name
        /// </summary>
        [JsonProperty("mapName")]
        public string MapName { get; private set; }
        /// <summary>
        /// Gets a name of map terrain
        /// </summary>
        [JsonProperty("mapTerrain")]
        public string MapTerrain { get; private set; }
        /// <summary>
        /// Gets a <see cref="TimeSpan"/> of how long the game is going
        /// </summary>
        [JsonProperty("gameTime"), JsonConverter(typeof(UnixTimeSpanConverter))]
        public TimeSpan GameTime { get; private set; }
    }
}
