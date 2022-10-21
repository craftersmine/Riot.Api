using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends lane position
    /// </summary>
    public enum LeagueMatchPosition
    {
        /// <summary>
        /// Unknown role
        /// </summary>
        /// <remarks>
        /// All players in League of Legends ARAM game mode will have this position
        /// </remarks>
        None,
        /// <summary>
        /// Top lane role
        /// </summary>
        TopLane,
        /// <summary>
        /// Jungle role
        /// </summary>
        Jungle,
        /// <summary>
        /// Middle lane role
        /// </summary>
        MiddleLane,
        /// <summary>
        /// Bottom lane role
        /// </summary>
        BottomLane,
        /// <summary>
        /// Utility role
        /// </summary>
        Utility,

        /// <inheritdoc cref="TopLane"/>
        Top = TopLane,
        /// <inheritdoc cref="MiddleLane"/>
        Mid = MiddleLane,
        /// <inheritdoc cref="BottomLane"/>
        Bot = BottomLane,
        /// <summary>
        /// Support (Utility role)
        /// </summary>
        Support = Utility
    }

    /// <summary>
    /// Contains an extensions methods for <see cref="LeagueMatchPosition"/>
    /// </summary>
    public static class LeagueMatchPositionExtensions
    {
        private const string Top = "TOP";
        private const string Jungle = "JUNGLE";
        private const string Mid = "MID";
        private const string Bot = "BOT";
        private const string Utility = "UTILITY";
        private const string None = "NONE";

        /// <summary>
        /// Gets a corresponding string for specified <see cref="LeagueMatchPosition"/> value
        /// </summary>
        /// <param name="pos">League of Legends position value</param>
        /// <returns>Corresponding <see langword="string"/> for <see cref="LeagueMatchPosition"/></returns>
        public static string GetLeagueMatchPositionString(this LeagueMatchPosition pos)
        {
            switch (pos)
            {
                case LeagueMatchPosition.TopLane:
                    return Top;
                case LeagueMatchPosition.Jungle:
                    return Jungle;
                case LeagueMatchPosition.MiddleLane:
                    return Mid;
                case LeagueMatchPosition.BottomLane:
                    return Bot;
                case LeagueMatchPosition.Utility:
                    return Utility;
                case LeagueMatchPosition.None:
                default:
                    return None;
            }
        }

        internal static LeagueMatchPosition GetLeagueMatchPositionFromString(this string str)
        {
            switch (str)
            {
                case Top:
                    return LeagueMatchPosition.TopLane;
                case Jungle:
                    return LeagueMatchPosition.Jungle;
                case Mid:
                    return LeagueMatchPosition.MiddleLane;
                case Bot:
                    return LeagueMatchPosition.BottomLane;
                case Utility:
                    return LeagueMatchPosition.Utility;
                case None:
                    return LeagueMatchPosition.None;
                default:
                    return LeagueMatchPosition.None;
            }
        }
    }
}
