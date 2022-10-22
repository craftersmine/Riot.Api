using System;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends building type
    /// </summary>
    public enum LeagueBuildingType
    {
        /// <summary>
        /// Generic tower
        /// </summary>
        Tower,
        /// <summary>
        /// Base inhibitor building
        /// </summary>
        Inhibitor
    }

    /// <summary>
    /// Contains static extension methods for <see cref="LeagueBuildingType"/>
    /// </summary>
    public static class LeagueBuildingTypeExtensions
    {
        private const string Tower = "TOWER_BUILDING";
        private const string Inhibitor = "INHIBITOR_BUILDING";
        
        /// <summary>
        /// Gets a corresponding string for <see cref="LeagueBuildingType"/> value
        /// </summary>
        /// <param name="buildingType">League of Legends <see cref="LeagueBuildingType"/> value</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="LeagueBuildingType"/> value</returns>
        /// <exception cref="ArgumentException">When none or unknown tower type is selected</exception>
        public static string GetStringFor(this LeagueBuildingType buildingType)
        {
            switch (buildingType)
            {
                case LeagueBuildingType.Tower:
                    return Tower;
                case LeagueBuildingType.Inhibitor:
                    return Inhibitor;
                default:
                    throw new ArgumentException("Unknown building type is selected", nameof(buildingType));
            }
        }

        internal static LeagueBuildingType GetLeagueBuildingTypeFromString(this string str)
        {
            switch (str)
            {
                case Tower:
                    return LeagueBuildingType.Tower;
                case Inhibitor:
                    return LeagueBuildingType.Inhibitor;
                default:
                    throw new ArgumentException("Unknown building tower received: " + str, nameof(str));
            }
        }
    }
}
