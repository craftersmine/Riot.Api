using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using craftersmine.Riot.Api.League.Client.Replay.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client.Replay
{
    /// <summary>
    /// Represents a League of Legends Replay recording settings
    /// </summary>
    public class LeagueReplayRecordingSettings
    {
        /// <summary>
        /// Gets or sets recording codec
        /// </summary>
        [JsonProperty("codec"), JsonConverter(typeof(AvContainerConverter))]
        public LeagueReplayAVContainer Codec { get; set; }
        /// <summary>
        /// Gets current replay rendering time
        /// </summary>
        [JsonProperty("currentTime"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan CurrentTime { get; private set; }
        /// <summary>
        /// Gets or sets replay recording end time
        /// </summary>
        [JsonProperty("endTime"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan EndTime { get; set; }
        /// <summary>
        /// Gets or sets replay recording start time
        /// </summary>
        [JsonProperty("startTime"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan StartTime { get; set; }
        /// <summary>
        /// Gets or sets <see langword="true"/> to force to use specified frame rate for recording
        /// </summary>
        [JsonProperty("enforceFrameRate")]
        public bool EnforceFrameRate { get; set; }
        /// <summary>
        /// Gets or sets <see langword="true"/> if final recording must be lossless
        /// </summary>
        [JsonProperty("lossless")]
        public bool IsLossless { get; set; }
        /// <summary>
        /// Gets <see langword="true"/> if replay is being recorded
        /// </summary>
        [JsonProperty("recording")]
        public bool IsRecording { get; private set; }
        /// <summary>
        /// Gets or sets final recording frame rate
        /// </summary>
        [JsonProperty("framesPerSecond")]
        public int FramesPerSecond { get; set; }
        /// <summary>
        /// Gets or sets final recording frame width
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }
        /// <summary>
        /// Gets or sets final recording frame height
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }
        /// <summary>
        /// Gets or sets final recording file path
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }
        /// <summary>
        /// Gets or sets replay speed for recording
        /// </summary>
        [JsonProperty("replaySpeed")]
        public float ReplaySpeed { get; set; }
    }
}
