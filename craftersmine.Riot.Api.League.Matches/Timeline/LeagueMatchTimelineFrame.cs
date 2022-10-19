using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline
{
    /// <summary>
    /// Represents a League of Legends match timeline frame
    /// </summary>
    public class LeagueMatchTimelineFrame
    {
        /// <summary>
        /// Gets an array of League of Legends match timeline current frame events
        /// </summary>
        [JsonProperty("events")]
        public ILeagueMatchTimelineFrameEvent[] Events { get; private set; }
        /// <summary>
        /// Gets an array of League of Legends match timeline current participant frames
        /// </summary>
        [JsonProperty("participantFrames")]
        public LeagueMatchTimelineParticipantFrame[] ParticipantFrames { get; private set; }
        /// <summary>
        /// Gets a <see cref="TimeSpan"/> timestamp of frame from the game beginning
        /// </summary>
        [JsonProperty("timestamp"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan Timestamp { get; private set; }
    }
}
