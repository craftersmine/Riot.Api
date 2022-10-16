using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Riot.Api.League.SummonerLeagues
{
    /// <summary>
    /// Represents League of Legends ranked tier
    /// </summary>
    public enum LeagueRankedTier
    {
        /// <summary>
        /// Unknown rank
        /// </summary>
        Unknown,
        /// <summary>
        /// Iron tier
        /// </summary>
        Iron,
        /// <summary>
        /// Bronze tier
        /// </summary>
        Bronze,
        /// <summary>
        /// Silver tier
        /// </summary>
        Silver,
        /// <summary>
        /// Gold tier
        /// </summary>
        Gold,
        /// <summary>
        /// Platinum tier
        /// </summary>
        Platinum,
        /// <summary>
        /// Diamond tier
        /// </summary>
        Diamond,
        /// <summary>
        /// Master tier
        /// </summary>
        Master,
        /// <summary>
        /// Grandmaster tier
        /// </summary>
        Grandmaster,
        /// <summary>
        /// Challenger tier
        /// </summary>
    }

    public static class LeagueRankedTierExtensions
    {
        internal const string IronTier = "IRON";
        internal const string BronzeTier = "BRONZE";
        internal const string SilverTier = "SILVER";
        internal const string GoldTier = "GOLD";
        internal const string PlatinumTier = "PLATINUM";
        internal const string DiamondTier = "DIAMOND";
        internal const string MasterTier = "MASTER";
        internal const string GrandmasterTier = "GRANDMASTER";
        internal const string ChallengerTier = "CHALLENGER";

        /// <summary>
        /// Returns string for specified rank
        /// </summary>
        /// <param name="tier">League of Legends rank</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetRankedTierString(this LeagueRankedTier tier)
        {
            switch (tier)
            {
                case LeagueRankedTier.Iron:
                    return IronTier;
                case LeagueRankedTier.Bronze:
                    return BronzeTier;
                case LeagueRankedTier.Silver:
                    return SilverTier;
                case LeagueRankedTier.Gold:
                    return GoldTier;
                case LeagueRankedTier.Platinum:
                    return PlatinumTier;
                case LeagueRankedTier.Diamond:
                    return DiamondTier;
                case LeagueRankedTier.Master:
                    return MasterTier;
                case LeagueRankedTier.Grandmaster:
                    return GrandmasterTier;
                case LeagueRankedTier.Challenger:
                    return ChallengerTier;
                default:
                    throw new ArgumentException("Unknown ranked tier selected!", nameof(tier));
            }
        }

        internal static LeagueRankedTier GetLeagueRankedTierFromString(this string str)
        {
            switch (str.ToUpper())
            {
                case IronTier:
                    return LeagueRankedTier.Iron;
                case BronzeTier:
                    return LeagueRankedTier.Bronze;
                case SilverTier:
                    return LeagueRankedTier.Silver;
                case GoldTier:
                    return LeagueRankedTier.Gold;
                case PlatinumTier:
                    return LeagueRankedTier.Platinum;
                case DiamondTier:
                    return LeagueRankedTier.Diamond;
                case MasterTier:
                    return LeagueRankedTier.Master;
                case GrandmasterTier:
                    return LeagueRankedTier.Grandmaster;
                case ChallengerTier:
                    return LeagueRankedTier.Challenger;
                default:
                    return LeagueRankedTier.Unknown;
            }
        }
    }
}
