using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Tournament
{
    /// <summary>
    /// Represents a League of Legends game map
    /// </summary>
    public enum LeagueMapType
    {
        /// <summary>
        /// Standard Summoners Rift map
        /// </summary>
        SummonersRift,
        /// <summary>
        /// ARAM Howling Abyss map
        /// </summary>
        HowlingAbyss
    }
    
    /// <summary>
    /// Contains a static methods for <see cref="LeagueMapType"/> enum extensions
    /// </summary>
    public static class LeagueMapTypeExtensions
    {
        private const string SummonersRift = "SUMMONERS_RIFT";
        private const string HowlingAbyss = "HOWLING_ABYSS";
        
        /// <summary>
        /// Gets a corresponding string for <see cref="LeagueMapType"/>
        /// </summary>
        /// <param name="mapType">League of Legends match map type value</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="LeagueMapType"/> value</returns>
        /// <exception cref="ArgumentException">When unknown value is selected</exception>
        public static string GetStringFor(this LeagueMapType mapType)
        {
            switch (mapType)
            {
                case LeagueMapType.SummonersRift:
                    return SummonersRift;
                case LeagueMapType.HowlingAbyss:
                    return HowlingAbyss;
            }

            throw new ArgumentException("Unknown value selected for map type", nameof(mapType));
        }

        internal static LeagueMapType GetLeagueMapTypeFromString(this string str)
        {
            switch (str)
            {
                case SummonersRift:
                    return LeagueMapType.SummonersRift;
                case HowlingAbyss:
                    return LeagueMapType.HowlingAbyss;
                default:
                    throw new ArgumentException("Unknown map type provided: " + str, nameof(str));
            }
        }
    }
}
