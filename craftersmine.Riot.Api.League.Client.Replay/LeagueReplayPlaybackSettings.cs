using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client.Replay
{
    /// <summary>
    /// Represents a League of Legends replay playback settings
    /// </summary>
    public class LeagueReplayPlaybackSettings
    {
        /// <summary>
        /// Gets or sets replay playback speed (ex. 0.5x, 2.0x, etc.)
        /// </summary>
        [JsonProperty("speed")]
        public float PlaybackSpeed { get; set; }
        /// <summary>
        /// Gets replay total length
        /// </summary>
        [JsonProperty("length"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan Length { get; private set; }
        /// <summary>
        /// Gets or sets current replay position time
        /// </summary>
        [JsonProperty("time")]
        public TimeSpan Position { get; set; }
        /// <summary>
        /// Gets or sets <see langword="true"/> to replay being paused or resumed
        /// </summary>
        [JsonProperty("paused")]
        public bool IsPaused { get; set; }
        /// <summary>
        /// Gets or sets <see langword="true"/> if replay is in seeking mode
        /// </summary>
        [JsonProperty("seeking")]
        public bool IsSeeking { get; set; }
    }
}
