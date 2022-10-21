using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
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
