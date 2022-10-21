using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends damage source type
    /// </summary>
    public enum LeagueDamageType
    {
        /// <summary>
        /// Any champion related damage
        /// </summary>
        Other,
        /// <summary>
        /// Any tower related damage (towers, fountain)
        /// </summary>
        Tower,
        /// <summary>
        /// Any minion damage
        /// </summary>
        Minion,
        /// <summary>
        /// Any monster damage (jungle monsters, elite monsters)
        /// </summary>
        Monster,
        /// <summary>
        /// Unknown damage source
        /// </summary>
        Unknown
    }

    /// <summary>
    /// Contains static extension methods for <see cref="LeagueDamageType"/>
    /// </summary>
    public static class LeagueDamageTypeExtensions
    {
        private const string OtherDamage = "OTHER";
        private const string TowerDamage = "TOWER";
        private const string MinionDamage = "MINION";
        private const string MonsterDamage = "MONSTER";

        /// <summary>
        /// Gets a corresponding string for <see cref="LeagueDamageType"/> value
        /// </summary>
        /// <param name="damageType"><see cref="LeagueDamageType"/> value</param>
        /// <returns>A corresponding <see langword="string"/> for specified <see cref="LeagueDamageType"/> value</returns>
        /// <exception cref="ArgumentException">When unknown damage type selected</exception>
        public static string GetStringFor(this LeagueDamageType damageType)
        {
            switch (damageType)
            {
                case LeagueDamageType.Other:
                    return OtherDamage;
                case LeagueDamageType.Minion:
                    return MinionDamage;
                case LeagueDamageType.Tower:
                    return TowerDamage;
                case LeagueDamageType.Monster:
                    return MonsterDamage;
                default:
                    throw new ArgumentException("Unknown damage type selected!", nameof(damageType));
            }
        }

        internal static LeagueDamageType GetLeagueDamageTypeFromString(this string str)
        {
            switch (str)
            {
                case OtherDamage:
                    return LeagueDamageType.Other;
                case MinionDamage:
                    return LeagueDamageType.Minion;
                case TowerDamage:
                    return LeagueDamageType.Tower;
                case MonsterDamage:
                    return LeagueDamageType.Monster;
                default:
                    return LeagueDamageType.Unknown;
            }
        }
    }
}
