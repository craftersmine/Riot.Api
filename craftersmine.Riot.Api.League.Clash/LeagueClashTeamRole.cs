using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Clash
{
    public enum LeagueClashTeamRole
    {
        Captain,
        Member,
        Unknown
    }

    public static class LeagueClashTeamRoleExtensions
    {
        private const string CaptainRole = "CAPTAIN";
        private const string MemberRole = "MEMBER";

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
