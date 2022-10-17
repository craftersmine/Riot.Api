using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends match types
    /// </summary>
    public enum LeagueMatchType
    {
        /// <summary>
        /// Normal League of Legends match game
        /// </summary>
        Normal,
        /// <summary>
        /// Ranked League of Legends match game
        /// </summary>
        Ranked,
        /// <summary>
        /// Clash tournament or any other League of Legends tournament match game
        /// </summary>
        Tournament,
        /// <summary>
        /// Any tutorial League of Legends match game
        /// </summary>
        Tutorial
    }

    /// <summary>
    /// Contains static extensions for <see cref="LeagueMatchType"/>
    /// </summary>
    public static class LeagueMatchTypeExtensions
    {
        private const string NormalsType = "normal";
        private const string RankedType = "ranked";
        private const string TournamentType = "tourney";
        private const string TutorialType = "tutorial";

        /// <summary>
        /// Gets a corresponding API-correct string for specified <see cref="LeagueMatchType"/>
        /// </summary>
        /// <param name="type">Match type value to fetch</param>
        /// <returns>A corresponding string for specified value</returns>
        /// <exception cref="ArgumentException">When somehow you passed a non-existent enum value</exception>
        public static string GetLeagueMatchTypeString(this LeagueMatchType type)
        {
            switch (type)
            {
                case LeagueMatchType.Normal:
                    return NormalsType;
                case LeagueMatchType.Ranked:
                    return RankedType;
                case LeagueMatchType.Tournament:
                    return TournamentType;
                case LeagueMatchType.Tutorial:
                    return TutorialType;
            }

            throw new ArgumentException("Invalid match type selected!");
        }
    }
}
