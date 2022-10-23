using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Tournament
{
    /// <summary>
    /// Represents a League of Legends match spectator type
    /// </summary>
    public enum LeagueSpectatorType
    {
        /// <summary>
        /// None of spectators are allowed
        /// </summary>
        None,
        /// <summary>
        /// Only lobby members are allowed to spectate
        /// </summary>
        LobbyOnly,
        /// <summary>
        /// All allowed to spectate
        /// </summary>
        All
    }
    
    /// <summary>
    /// Contains a static methods for <see cref="LeaguePickType"/> enum extensions
    /// </summary>
    public static class LeagueSpectatorTypeExtensions
    {
        private const string None = "NONE";
        private const string LobbyOnly = "LOBBY_ONLY";
        private const string All = "ALL";
        
        /// <summary>
        /// Gets a corresponding string for <see cref="LeagueSpectatorType"/>
        /// </summary>
        /// <param name="spectatorType">League of Legends match spectator type value</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="LeagueSpectatorType"/> value</returns>
        /// <exception cref="ArgumentException">When unknown value is selected</exception>
        public static string GetStringFor(this LeagueSpectatorType spectatorType)
        {
            switch (spectatorType)
            {
                case LeagueSpectatorType.None:
                    return None;
                case LeagueSpectatorType.LobbyOnly:
                    return LobbyOnly;
                case LeagueSpectatorType.All:
                    return All;
            }

            throw new ArgumentException("Unknown value selected for spectator type", nameof(spectatorType));
        }

        internal static LeagueSpectatorType GetLeagueSpectatorTypeFromString(this string str)
        {
            switch (str)
            {
                case None:
                    return LeagueSpectatorType.None;
                case LobbyOnly:
                    return LeagueSpectatorType.LobbyOnly;
                case All:
                    return LeagueSpectatorType.All;
                default:
                    throw new ArgumentException("Unknown value passed for spectator type: " + str, nameof(str));
            }
        }
    }
}
