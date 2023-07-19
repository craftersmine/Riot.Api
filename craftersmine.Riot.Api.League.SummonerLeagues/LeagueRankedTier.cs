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
        /// Emerald tier
        /// </summary>
        Emerald,
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
        Challenger,
        /// <summary>
        /// Unranked
        /// </summary>
        Unranked
    }
    
    /// <summary>
    /// Contains a static methods for <see cref="LeagueRankedTier"/> enum extensions
    /// </summary>
    public static class LeagueRankedTierExtensions
    {
        private const string IronTier = "IRON";
        private const string BronzeTier = "BRONZE";
        private const string SilverTier = "SILVER";
        private const string GoldTier = "GOLD";
        private const string PlatinumTier = "PLATINUM";
        private const string EmeraldTier = "EMERALD";
        private const string DiamondTier = "DIAMOND";
        private const string MasterTier = "MASTER";
        private const string GrandmasterTier = "GRANDMASTER";
        private const string ChallengerTier = "CHALLENGER";
        private const string UnrankedTier = "UNRANKED";

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
                case LeagueRankedTier.Emerald:
                    return EmeraldTier;
                case LeagueRankedTier.Diamond:
                    return DiamondTier;
                case LeagueRankedTier.Master:
                    return MasterTier;
                case LeagueRankedTier.Grandmaster:
                    return GrandmasterTier;
                case LeagueRankedTier.Challenger:
                    return ChallengerTier;
                case LeagueRankedTier.Unranked:
                    return UnrankedTier;
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
                case EmeraldTier:
                    return LeagueRankedTier.Emerald;
                case DiamondTier:
                    return LeagueRankedTier.Diamond;
                case MasterTier:
                    return LeagueRankedTier.Master;
                case GrandmasterTier:
                    return LeagueRankedTier.Grandmaster;
                case ChallengerTier:
                    return LeagueRankedTier.Challenger;
                case UnrankedTier:
                    return LeagueRankedTier.Unranked;
                default:
                    return LeagueRankedTier.Unknown;
            }
        }
    }
}
