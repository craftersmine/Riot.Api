using System;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends special kill type
    /// </summary>
    public enum LeagueSpecialKillType
    {
        /// <summary>
        /// First blood
        /// </summary>
        FirstBlood,
        /// <summary>
        /// Any of multi kills (double, triple, quadra, penta, hexa)
        /// </summary>
        MultiKill,
        /// <summary>
        /// Enemy team was aced
        /// </summary>
        Ace
    }

    /// <summary>
    /// Contains static extension methods for <see cref="LeagueSpecialKillType"/>
    /// </summary>
    public static class LeagueSpecialKillTypeExtensions
    {
        private const string FirstBlood = "KILL_FIRST_BLOOD";
        private const string MultiKill = "KILL_MULTI";
        private const string Ace = "KILL_ACE";

        /// <summary>
        /// Gets a corresponding string for <see cref="LeagueSpecialKillType"/> value
        /// </summary>
        /// <param name="specialKillType"><see cref="LeagueSpecialKillType"/> value</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="LeagueSpecialKillType"/> value</returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetStringFor(this LeagueSpecialKillType specialKillType)
        {
            switch (specialKillType)
            {
                case LeagueSpecialKillType.FirstBlood:
                    return FirstBlood;
                case LeagueSpecialKillType.MultiKill:
                    return MultiKill;
                case LeagueSpecialKillType.Ace:
                    return Ace;
                default:
                    throw new ArgumentException("Unknown special kill value is selected!");
            }
        }

        internal static LeagueSpecialKillType GetLeagueSpecialKillTypeFromString(this string str)
        {
            switch (str)
            {
                case FirstBlood:
                    return LeagueSpecialKillType.FirstBlood;
                case MultiKill:
                    return LeagueSpecialKillType.MultiKill;
                case Ace:
                    return LeagueSpecialKillType.Ace;
                default:
                    throw new ArgumentException("Unknown value for special kill " + str, nameof(str));
            }
        }
    }
}
