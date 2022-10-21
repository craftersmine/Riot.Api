using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends elite monster type
    /// </summary>
    public enum EliteMonsterType
    {
        /// <summary>
        /// Rift Herald
        /// </summary>
        RiftHerald,
        /// <summary>
        /// Any dragon
        /// </summary>
        Dragon,
        /// <summary>
        /// Baron Nashor
        /// </summary>
        BaronNashor
    }

    /// <summary>
    /// Contains static extension methods for <see cref="EliteMonsterType"/>
    /// </summary>
    public static class EliteMonsterTypeExtensions
    {
        private const string RiftHerald = "RIFTHERALD";
        private const string Dragon = "DRAGON";
        private const string BaronNashor = "BARON_NASHOR";

        /// <summary>
        /// Gets a corresponding string value for <see cref="EliteMonsterType"/>
        /// </summary>
        /// <param name="eliteMonsterType">League of Legends <see cref="EliteMonsterType"/> value</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="EliteMonsterType"/> value</returns>
        /// <exception cref="ArgumentException">When unknown elite monster type is selected</exception>
        public static string GetStringFor(this EliteMonsterType eliteMonsterType)
        {
            switch (eliteMonsterType)
            {
                case EliteMonsterType.RiftHerald:
                    return RiftHerald;
                case EliteMonsterType.Dragon:
                    return Dragon;
                case EliteMonsterType.BaronNashor:
                    return BaronNashor;
                default:
                    throw new ArgumentException("Unknown value for elite monster type selected",
                        nameof(eliteMonsterType));
            }
        }

        internal static EliteMonsterType GetEliteMonsterTypeFromString(this string str)
        {
            switch (str)
            {
                case RiftHerald:
                    return EliteMonsterType.RiftHerald;
                case Dragon:
                    return EliteMonsterType.Dragon;
                case BaronNashor:
                    return EliteMonsterType.BaronNashor;
                default:
                    throw new ArgumentException("Unknown value for elite monster type " + str, nameof(str));
            }
        }
    }
}
