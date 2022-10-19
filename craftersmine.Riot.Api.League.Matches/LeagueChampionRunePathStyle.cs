using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends rune set path type
    /// </summary>
    public enum LeagueChampionRunePathStyle
    {
        /// <summary>
        /// Primary rune set (4 rune set)
        /// </summary>
        Primary,
        /// <summary>
        /// Secondary rune set (2 rune set + shards)
        /// </summary>
        Secondary
    }

    /// <summary>
    /// Contains extensions methods for <see cref="LeagueChampionRunePathStyle"/>
    /// </summary>
    public static class LeagueChampionRunePathStyleExtensions
    {
        private const string PrimaryStyle = "primaryStyle";
        private const string SecondaryStyle = "subStyle";
        
        /// <summary>
        /// Gets corresponding string for <see cref="LeagueChampionRunePathStyle"/> value
        /// </summary>
        /// <param name="style">Rune path value</param>
        /// <returns>A <see langword="string"/> for specified value</returns>
        /// <exception cref="Exception"></exception>
        public static string GetChampionRunePathStyleString(this LeagueChampionRunePathStyle style)
        {
            switch (style)
            {
                case LeagueChampionRunePathStyle.Primary:
                    return PrimaryStyle;
                case LeagueChampionRunePathStyle.Secondary:
                    return SecondaryStyle;
                default:
                    throw new Exception("Unknown rune path style selected! This should not happen");
            }
        }

        internal static LeagueChampionRunePathStyle GetChampionRunePathStyleFromString(this string str)
        {
            switch (str)
            {
                case PrimaryStyle:
                    return LeagueChampionRunePathStyle.Primary;
                case SecondaryStyle:
                    return LeagueChampionRunePathStyle.Secondary;
                default:
                    throw new ArgumentException("Unknown rune path style!", nameof(str));
            }
        }
    }
}
