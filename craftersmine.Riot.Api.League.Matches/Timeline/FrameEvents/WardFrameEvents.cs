using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using craftersmine.Riot.Api.League.Matches.Converters.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends match timeline ward placement frame event
    /// </summary>
    public class WardPlacedFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets an ID of participant who placed a ward
        /// </summary>
        [JsonProperty("creatorId")]
        public int CreatorId { get; private set; }
        /// <summary>
        /// Gets a type of ward that was placed
        /// </summary>
        [JsonProperty("wardType"), JsonConverter(typeof(WardTypeConverter))]
        public WardType WardType { get; private set; }
    }

    /// <summary>
    /// Represents a League of Legends match timeline ward destroyed frame event
    /// </summary>
    public class WardKilledFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets an ID of participant who killed a ward
        /// </summary>
        [JsonProperty("killerId")]
        public int KillerId { get; private set; }
        /// <summary>
        /// Gets a type of ward that was killed
        /// </summary>
        [JsonProperty("wardType"), JsonConverter(typeof(WardTypeConverter))]
        public WardType WardType { get; private set; }
    }
}
