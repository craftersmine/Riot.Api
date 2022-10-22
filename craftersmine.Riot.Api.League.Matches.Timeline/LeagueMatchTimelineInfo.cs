using System;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline
{
    /// <summary>
    /// Represents a League of Legends match timeline information
    /// </summary>
    public class LeagueMatchTimelineInfo
    {
        /// <summary>
        /// Gets a League of Legends match game ID
        /// </summary>
        [JsonProperty("gameId")]
        public long GameId { get; private set; }
        /// <summary>
        /// Gets an interval <see cref="TimeSpan"/> between information frames
        /// </summary>
        [JsonProperty("frameInterval"), JsonConverter(typeof(UnixTimeSpanConverter), false)]
        public TimeSpan FrameInterval { get; private set; }
        /// <summary>
        /// Gets an array of League of Legends frames in match timeline
        /// </summary>
        [JsonProperty("frames")]
        public LeagueMatchTimelineFrame[] Frames { get; private set; }
        /// <summary>
        /// Gets an array of League of Legends match participants
        /// </summary>
        [JsonProperty("participants")]
        public LeagueMatchTimelineParticipant[] Participants { get; private set; }
    }
}
