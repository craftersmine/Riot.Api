using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using craftersmine.Riot.Api.Common.Converters;
using craftersmine.Riot.Api.Tft.Matches.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tft.Matches
{
    /// <summary>
    /// Represents a Teamfight Tactics match information
    /// </summary>
    public class TftMatchInfo
    {
        private readonly Regex VersionStringRegex = new Regex(@"Version (.*) \((.*)\) \[(.*)\]");
        /// <summary>
        /// Gets Teamfight Tactics match queue ID
        /// </summary>
        [JsonProperty("queue_id")]
        public int QueueId { get; private set; }
        /// <summary>
        /// Gets a Teamfight Tactics set number which was when this game was played
        /// </summary>
        [JsonProperty("tft_set_number")]
        public int SetNumber { get; private set; }
        /// <summary>
        /// Gets a Teamfight Tactics set core name
        /// </summary>
        [JsonProperty("tft_set_core_name")]
        public string SetCoreName { get; private set; }
        /// <summary>
        /// Gets a Teamfight Tactics game type
        /// </summary>
        [JsonProperty("tft_game_type")]
        public string GameType { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> timestamp when game was started
        /// </summary>
        [JsonProperty("game_datetime"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime GameStartTimestamp { get; private set; }
        /// <summary>
        /// Gets a <see cref="TimeSpan"/> of how long the game was
        /// </summary>
        [JsonProperty("game_length"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan GameLength { get; private set; }

        /// <summary>
        /// Gets a <see cref="Version"/> of game on which this game was played
        /// </summary>
        public Version GameVersion => Version.Parse(VersionStringRegex.Match(GameVersionString).Groups[1].Value);

        /// <summary>
        /// Gets a string version of game on which this game was played
        /// </summary>
        [JsonProperty("game_version")]
        public string GameVersionString { get; private set; }
        /// <summary>
        /// Gets an array of game participants
        /// </summary>
        [JsonProperty("participants")]
        public TftParticipant[] Participants { get; private set; }
    }
}
