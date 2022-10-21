using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends game role
    /// </summary>
    public enum LeagueMatchRole
    {
        /// <summary>
        /// No role defined or unknown role
        /// </summary>
        None,
        /// <summary>
        /// Solo lane (top lane or middle lane)
        /// </summary>
        Solo,
        /// <summary>
        /// Duo lane (bottom lane)
        /// </summary>
        Duo,
        /// <summary>
        /// AD Carry on duo lane
        /// </summary>
        DuoCarry,
        /// <summary>
        /// Support (Utility) on duo lane
        /// </summary>
        DuoSupport
    }

    /// <summary>
    /// Contains static extensions methods for <see cref="LeagueMatchRole"/>
    /// </summary>
    public static class LeagueMatchRoleExtensions
    {
        private const string None = "NONE";
        private const string Solo = "SOLO";
        private const string Duo = "DUO";
        private const string DuoCarry = "DUO_CARRY";
        private const string DuoSupport = "DUO_SUPPORT";

        /// <summary>
        /// Gets a corresponding string for <see cref="LeagueMatchRole"/> value
        /// </summary>
        /// <param name="role">League of Legends role value</param>
        /// <returns>Corresponding <see langword="string"/> for <see cref="LeagueMatchRole"/> value</returns>
        /// <exception cref="Exception"></exception>
        public static string GetLeagueMatchRoleString(this LeagueMatchRole role)
        {
            switch (role)
            {
                case LeagueMatchRole.None:
                    return None;
                case LeagueMatchRole.Solo:
                    return Solo;
                case LeagueMatchRole.Duo:
                    return Duo;
                case LeagueMatchRole.DuoCarry:
                    return DuoCarry;
                case LeagueMatchRole.DuoSupport:
                    return DuoSupport;
                default:
                    throw new Exception("Should not happen!");
            }
        }

        internal static LeagueMatchRole GetLeagueMatchRoleFromString(this string str)
        {
            switch (str)
            {
                case None:
                    return LeagueMatchRole.None;
                case Solo:
                    return LeagueMatchRole.Solo;
                case Duo:
                    return LeagueMatchRole.Duo;
                case DuoCarry:
                    return LeagueMatchRole.DuoCarry;
                case DuoSupport:
                    return LeagueMatchRole.DuoSupport;
                default:
                    return LeagueMatchRole.None;
            }
        }
    }
}
