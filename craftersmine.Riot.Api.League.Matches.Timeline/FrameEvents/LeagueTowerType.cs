using System;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends tower type
    /// </summary>
    public enum LeagueTowerType
    {
        /// <summary>
        /// Building is not a tower or has no type
        /// </summary>
        None,
        /// <summary>
        /// Outer lane turret
        /// </summary>
        Outer,
        /// <summary>
        /// Inner lane turret
        /// </summary>
        Inner,
        /// <summary>
        /// Inhibitor turret
        /// </summary>
        Base,
        /// <summary>
        /// Nexus turret
        /// </summary>
        Nexus,

        /// <inheritdoc cref="Outer"/>
        T1 = Outer,
        /// <inheritdoc cref="Inner"/>
        T2 = Inner,
        /// <inheritdoc cref="Base"/>
        T3 = Base,

        /// <inheritdoc cref="Base"/>
        Inhibitor = Base,
    }

    /// <summary>
    /// Contains static extension methods for <see cref="LeagueTowerTypeExtensions"/>
    /// </summary>
    public static class LeagueTowerTypeExtensions
    {
        private const string OuterTurret = "OUTER_TURRET";
        private const string InnerTurret = "INNER_TURRET";
        private const string BaseTurret = "BASE_TURRET";
        private const string NexusTurret = "NEXUS_TURRET";

        /// <summary>
        /// Gets a corresponding string for <see cref="LeagueTowerType"/> value
        /// </summary>
        /// <param name="towerType">League of Legends <see cref="LeagueTowerType"/> value</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="LeagueTowerType"/> value</returns>
        /// <exception cref="ArgumentException">When none or unknown tower type is selected</exception>
        public static string GetStringFor(this LeagueTowerType towerType)
        {
            switch (towerType)
            {
                case LeagueTowerType.Outer:
                    return OuterTurret;
                case LeagueTowerType.Inner:
                    return InnerTurret;
                case LeagueTowerType.Base:
                    return BaseTurret;
                case LeagueTowerType.Nexus:
                    return NexusTurret;
                case LeagueTowerType.None:
                default:
                    throw new ArgumentException("Unknown or none tower type selected!");
            }
        }

        internal static LeagueTowerType GetLeagueTowerTypeFromString(this string str)
        {
            switch (str)
            {
                case OuterTurret:
                    return LeagueTowerType.Outer;
                case InnerTurret:
                    return LeagueTowerType.Inner;
                case BaseTurret:
                    return LeagueTowerType.Base;
                case NexusTurret:
                    return LeagueTowerType.Nexus;
                default:
                    return LeagueTowerType.None;
            }
        }
    }
}
