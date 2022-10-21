using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using craftersmine.Riot.Api.League.Matches.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a generic League of Legends match timeline frame event
    /// </summary>
    public class BaseTimelineFrameEvent : ILeagueTimelineFrameEvent
    {
        /// <inheritdoc cref="ILeagueTimelineFrameEvent.Type"/>
        [JsonProperty("type"), JsonConverter(typeof(LeagueTimelineFrameEventTypeConverter))]
        public LeagueTimelineFrameEventType Type { get; private set; }
        /// <inheritdoc cref="ILeagueTimelineFrameEvent.Timestamp"/>
        [JsonProperty("timestamp"), JsonConverter(typeof(UnixTimeSpanConverter), false)]
        public TimeSpan Timestamp { get; private set; }
    }
}
