using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Riot.Api.League.SummonerLeagues
{
    public enum LeagueRankedTier
    {
        Unknown,
        Iron,
        Bronze,
        Silver,
        Gold,
        Platinum,
        Diamond,
        Master,
        Grandmaster,
        Challenger
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
