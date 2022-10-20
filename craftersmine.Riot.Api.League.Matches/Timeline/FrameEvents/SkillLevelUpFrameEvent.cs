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

    /// <summary>
    /// Represents types of champion skill level ups
    /// </summary>
    public enum SkillLevelUpType
    {
        /// <summary>
        /// Normal level up
        /// </summary>
        Normal,
        /// <summary>
        /// Unknown type of level up
        /// </summary>
        Unknown
    }

    /// <summary>
    /// Contains extensions for <see cref="SkillLevelUpType"/>
    /// </summary>
    public static class SkillLevelUpTypeExtensions
    {
        private const string Normal = "NORMAL";

        /// <summary>
        /// Gets a corresponding string for <see cref="SkillLevelUpType"/> value
        /// </summary>
        /// <param name="levelUpType"><see cref="SkillLevelUpType"/> value</param>
        /// <returns>A corresponding <see cref="string"/> for <see cref="SkillLevelUpType"/></returns>
        /// <exception cref="ArgumentException">When unknown value is selected</exception>
        public static string GetStringFor(this SkillLevelUpType levelUpType)
        {
            switch (levelUpType)
            {
                case SkillLevelUpType.Normal:
                    return Normal;
                default:
                    throw new ArgumentException("Unknown skill level up type selected");
            }
        }

        internal static SkillLevelUpType GetSkillLevelUpTypeFromString(this string str)
        {
            switch (str)
            {
                case Normal:
                    return SkillLevelUpType.Normal;
                default:
                    return SkillLevelUpType.Unknown;
            }
        }
    }
}
