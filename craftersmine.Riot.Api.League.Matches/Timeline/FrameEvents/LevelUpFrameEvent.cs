using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends champion level up event
    /// </summary>
    public class LevelUpFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets a Participant ID in match which had this event
        /// </summary>
        [JsonProperty("participantId")]
        public int ParticipantId { get; private set; }
        /// <summary>
        /// Gets a new champion level when level up occurred
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; private set; }
    }
}
