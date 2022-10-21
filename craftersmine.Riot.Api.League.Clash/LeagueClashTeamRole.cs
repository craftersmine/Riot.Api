using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Clash
{
    /// <summary>
    /// Represents a role in League of Legends Clash team
    /// </summary>
    public enum LeagueClashTeamRole
    {
        /// <summary>
        /// Participant is a captain of team
        /// </summary>
        Captain,
        /// <summary>
        /// Participant is a member of team
        /// </summary>
        Member,
        /// <summary>
        /// Participant has an unknown status
        /// </summary>
        Unknown
    }

    /// <summary>
    /// Contains a static extensions for <see cref="LeagueClashTeamRole"/>
    /// </summary>
    public static class LeagueClashTeamRoleExtensions
    {
        private const string CaptainRole = "CAPTAIN";
        private const string MemberRole = "MEMBER";

        /// <summary>
        /// Gets a corresponding string for <see cref="LeagueClashTeamRole"/> value
        /// </summary>
        /// <param name="role">League of Legends Clash role value</param>
        /// <returns>A corresponding <see langword="string"/> for specified value</returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetLeagueClashTeamRoleString(this LeagueClashTeamRole role)
        {
            switch (role)
            {
                case LeagueClashTeamRole.Captain:
                    return CaptainRole;
                case LeagueClashTeamRole.Member:
                    return MemberRole;
                default:
                    throw new ArgumentException("Unknown Clash team role selected!", nameof(role));
            }
        }

        internal static LeagueClashTeamRole GetLeagueClashTeamRoleFromString(this string str)
        {
            switch (str)
            {
                case CaptainRole:
                    return LeagueClashTeamRole.Captain;
                case MemberRole:
                    return LeagueClashTeamRole.Member;
                default:
                    return LeagueClashTeamRole.Unknown;
            }
        }
    }
}
