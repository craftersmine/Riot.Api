using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends match timeline pause ended frame event
    /// </summary>
    public class PauseEndTimelineFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets a real world <see cref="DateTime"/> when <see cref="LeagueTimelineFrameEventType.PauseEnd"/> event was created
        /// </summary>
        [JsonProperty("realTimestamp"), JsonConverter(typeof(UnixDateTimeConverter), false)]
        public DateTime RealTimestamp { get; private set; }
    }
}
