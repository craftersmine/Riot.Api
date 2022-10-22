using System;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends lane
    /// </summary>
    public enum LeagueLane
    {
        /// <summary>
        /// Top lane
        /// </summary>
        Top,
        /// <summary>
        /// Middle lane
        /// </summary>
        Middle,
        /// <summary>
        /// Bottom lane
        /// </summary>
        Bottom
    }

    /// <summary>
    /// Contains static extension methods for <see cref="LeagueLane"/>
    /// </summary>
    public static class LeagueLaneExtensions
    {
        private const string TopLane = "TOP_LANE";
        private const string MidLane = "MID_LANE";
        private const string BotLane = "BOT_LANE";

        /// <summary>
        /// Gets a corresponding string for <see cref="SkillLevelUpType"/> value
        /// </summary>
        /// <param name="lane"><see cref="LeagueLane"/> value</param>
        /// <returns>A corresponding <see cref="string"/> for <see cref="LeagueLane"/></returns>
        /// <exception cref="ArgumentException">When unknown value is selected</exception>
        public static string GetStringFor(this LeagueLane lane)
        {
            switch (lane)
            {
                case LeagueLane.Top:
                    return TopLane;
                case LeagueLane.Middle:
                    return MidLane;
                case LeagueLane.Bottom:
                    return BotLane;
                default:
                    throw new ArgumentException("Unknown value for lane is selected!", nameof(lane));
            }
        }

        internal static LeagueLane GetLeagueLaneFromString(this string str)
        {
            switch (str)
            {
                case TopLane:
                    return LeagueLane.Top;
                case MidLane:
                    return LeagueLane.Middle;
                case BotLane:
                    return LeagueLane.Bottom;
                default:
                    throw new ArgumentException("Unknown value for lane " + str, nameof(str));
            }
        }
    }
}
