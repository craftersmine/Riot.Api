using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Spectator
{
    /// <summary>
    /// Represents a current League of Legends game information
    /// </summary>
    public class LeagueCurrentGameInfo
    {
        /// <summary>
        /// Gets a current game ID
        /// </summary>
        [JsonProperty("gameId")]
        public long GameId { get; private set; }
        /// <summary>
        /// Gets a game map ID
        /// </summary>
        [JsonProperty("mapId")]
        public long MapId { get; private set; }
        /// <summary>
        /// Gets a game queue configuration ID
        /// </summary>
        [JsonProperty("gameQueueConfigId")]
        public long GameQueueConfigId { get; private set; }
        /// <summary>
        /// Gets a game type
        /// </summary>
        [JsonProperty("gameType")]
        public string GameType { get; private set; }
        /// <summary>
        /// Gets a game mode type
        /// </summary>
        [JsonProperty("gameMode")]
        public string GameMode { get; private set; }
        /// <summary>
        /// Gets a League of Legends game server region on which game is running
        /// </summary>
        [JsonProperty("platformId"), JsonConverter(typeof(RiotPlatformAsLeagueRegionConverter), false)]
        public RiotPlatform ServerId { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> timestamp when game was started
        /// </summary>
        [JsonProperty("gameStartTime"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime StartTimestamp { get; private set; }
        /// <summary>
        /// Gets a current game length <see cref="TimeSpan"/>
        /// </summary>
        /// <remarks>
        /// Negative <see cref="TimeSpan"/> indicates that the game is not currently started for spectators
        /// </remarks>
        [JsonProperty("gameLength"), JsonConverter(typeof(UnixTimeSpanConverter))]
        public TimeSpan GameLength { get; private set; }
        /// <summary>
        /// Gets an array of game participants information
        /// </summary>
        [JsonProperty("participants")]
        public LeagueCurrentGameParticipant[] Participants { get; private set; }
        /// <summary>
        /// Gets a information for game observers
        /// </summary>
        [JsonProperty("observers")]
        public LeagueCurrentGameObservers Observers { get; private set; }
        /// <summary>
        /// Gets an array of banned champions in this game
        /// </summary>
        [JsonProperty("bannedChampions")]
        public LeagueCurrentGameBan[] BannedChampions { get; private set; }
    }
}
