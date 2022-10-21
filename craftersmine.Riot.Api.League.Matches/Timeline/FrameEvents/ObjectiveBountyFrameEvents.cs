using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends objective bounty pre-start timeline frame event
    /// </summary>
    public class ObjectiveBountyPrestartFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets a team ID for which objective bounty is starting
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; private set; }
        /// <summary>
        /// Gets an actual timespan within a match from game start
        /// </summary>
        [JsonProperty("actualStartTime"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan ActualStartTime { get; private set; }
    }

    /// <summary>
    /// Represents a League of Legends objective bounty finalizing timeline frame event
    /// </summary>
    public class ObjectiveBountyFinishFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets a team ID for which objective bounties are finishing
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; private set; }
    }
}
