using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Riot.Api.League.SummonerLeagues
{
    /// <summary>
    /// Represents a League of Legends ranked division (Rank - Division, Gold - I)
    /// </summary>
    public enum LeagueDivisionRank
    {
        /// <summary>
        /// Unknown division
        /// </summary>
        Unknown,
        /// <summary>
        /// First division
        /// </summary>
        I,
        /// <summary>
        /// Second division
        /// </summary>
        II,
        /// <summary>
        /// Third division
        /// </summary>
        III,
        /// <summary>
        /// Fourth division
        /// </summary>
        IV
    }
    
    /// <summary>
    /// Contains a static methods for <see cref="LeagueDivisionRank"/> enum extensions
    /// </summary>
    public static class LeagueDivisionRankExtensions
    {
        internal const string RankI = "I";
        internal const string RankII = "II";
        internal const string RankIII = "III";
        internal const string RankIV = "IV";

        /// <summary>
        /// Gets a representing string for specified division rank
        /// </summary>
        /// <param name="rank">League of Legends division rank</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetLeagueDivisionRankString(this LeagueDivisionRank rank)
        {
            switch (rank)
            {
                case LeagueDivisionRank.I:
                    return RankI;
                case LeagueDivisionRank.II:
                    return RankII;
                case LeagueDivisionRank.III:
                    return RankIII;
                case LeagueDivisionRank.IV:
                    return RankIV;
                default:
                    throw new ArgumentException("Unknown division rank selected!", nameof(rank));
            }
        }

        internal static LeagueDivisionRank GetLeagueDivisionFromString(this string str)
        {
            switch (str)
            {
                case RankI:
                    return LeagueDivisionRank.I;
                case RankII:
                    return LeagueDivisionRank.II;
                case RankIII:
                    return LeagueDivisionRank.III;
                case RankIV:
                    return LeagueDivisionRank.IV;
                default:
                    return LeagueDivisionRank.Unknown;
            }
        }
    }
}
