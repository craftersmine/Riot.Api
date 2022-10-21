using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Matches.Converters.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends champion skill level up frame event
    /// </summary>
    public class SkillLevelUpFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets a type of level up
        /// </summary>
        [JsonProperty("levelUpType"), JsonConverter(typeof(SkillLevelUpTypeConverter))]
        public SkillLevelUpType LevelUpType { get; private set; }
        /// <summary>
        /// Gets an ID of participant in this match who is leveled up skill
        /// </summary>
        [JsonProperty("participantId")]
        public int ParticipantId { get; private set; }
        /// <summary>
        /// Gets an ID of skill slot in which this skill is located
        /// </summary>
        [JsonProperty("skillSlot")]
        public int SkillSlot { get; private set; }
    }
}
