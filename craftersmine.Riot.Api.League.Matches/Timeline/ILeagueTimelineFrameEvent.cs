using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline
{
    /// <summary>
    /// Represents a generic League of Legends match timeline frame event
    /// </summary>
    public interface ILeagueTimelineFrameEvent
    {
        /// <summary>
        /// Gets a League of Legends match timeline frame event type
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(LeagueTimelineFrameEventType))]
        LeagueTimelineFrameEventType Type { get; }
        /// <summary>
        /// Gets a League of Legends match timeline frame event timestamp from game start
        /// </summary>
        [JsonProperty("timestamp"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        TimeSpan Timestamp { get; }
    }
}
