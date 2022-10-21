using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Clash
{
    /// <summary>
    /// Represents a League of Legends player position
    /// </summary>
    public enum LeaguePlayerPosition
    {
        /// <summary>
        /// Participant position is top lane
        /// </summary>
        Top,
        /// <summary>
        /// Participant position is jungle
        /// </summary>
        Jungle,
        /// <summary>
        /// Participant position is middle lane
        /// </summary>
        Middle,
        /// <summary>
        /// Participant position is bottom lane
        /// </summary>
        Bottom,
        /// <summary>
        /// Participant position is utility
        /// </summary>
        Utility,
        /// <summary>
        /// Participant position is support (same as utility)
        /// </summary>
        Support = Utility,
        /// <summary>
        /// Participant position is autofilled
        /// </summary>
        Fill,
        /// <summary>
        /// Participant position is unselected
        /// </summary>
        Unselected,
        /// <summary>
        /// Participant position is unknown
        /// </summary>
        Unknown
    }

    /// <summary>
    /// Contains a static extensions for <see cref="LeaguePlayerPosition"/>
    /// </summary>
    public static class LeaguePlayerPositionExtensions
    {
        private const string Top = "TOP";
        private const string Jungle = "JUNGLE";
        private const string Middle = "MIDDLE";
        private const string Bottom = "BOTTOM";
        private const string Utility = "UTILITY";
        private const string Fill = "FILL";
        private const string Unselected = "UNSELECTED";

        /// <summary>
        /// Gets a corresponding string for <see cref="LeaguePlayerPosition"/> value
        /// </summary>
        /// <param name="pos">League of Legends Clash player position value</param>
        /// <returns>A corresponding <see langword="string"/> for specified value</returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetLeaguePlayerPositionString(this LeaguePlayerPosition pos)
        {
            switch (pos)
            {
                case LeaguePlayerPosition.Top:
                    return Top;
                case LeaguePlayerPosition.Jungle:
                    return Jungle;
                case LeaguePlayerPosition.Middle:
                    return Middle;
                case LeaguePlayerPosition.Bottom:
                    return Bottom;
                case LeaguePlayerPosition.Utility:
                    return Utility;
                case LeaguePlayerPosition.Fill:
                    return Fill;
                case LeaguePlayerPosition.Unselected:
                    return Unselected;
                default:
                    throw new ArgumentException("Unknown player position selected!", nameof(pos));
            }
        }

        internal static LeaguePlayerPosition GetLeaguePlayerPositionFromString(this string str)
        {
            switch (str)
            {
                case Top:
                    return LeaguePlayerPosition.Top;
                case Jungle:
                    return LeaguePlayerPosition.Jungle;
                case Middle:
                    return LeaguePlayerPosition.Middle;
                case Bottom:
                    return LeaguePlayerPosition.Bottom;
                case Utility:
                    return LeaguePlayerPosition.Utility;
                case Fill:
                    return LeaguePlayerPosition.Fill;
                case Unselected:
                    return LeaguePlayerPosition.Unselected;
                default:
                    return LeaguePlayerPosition.Unknown;
            }
        }
    }
}
