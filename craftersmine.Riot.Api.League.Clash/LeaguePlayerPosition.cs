using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Clash
{
    public enum LeaguePlayerPosition
    {
        Top,
        Jungle,
        Middle,
        Bottom,
        Utility,
        Support = Utility,
        Fill,
        Unselected,
        Unknown
    }

    public static class LeaguePlayerPositionExtensions
    {
        private const string Top = "TOP";
        private const string Jungle = "JUNGLE";
        private const string Middle = "MIDDLE";
        private const string Bottom = "BOTTOM";
        private const string Utility = "UTILITY";
        private const string Fill = "FILL";
        private const string Unselected = "UNSELECTED";

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
