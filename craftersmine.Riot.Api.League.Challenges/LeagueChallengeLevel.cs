using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a League of Legends challenge level
    /// </summary>
    public enum LeagueChallengeLevel
    {
        /// <summary>
        /// Challenge is unranked
        /// </summary>
        None,
        /// <summary>
        /// Challenge has iron badge
        /// </summary>
        Iron,
        /// <summary>
        /// Challenge has bronze badge
        /// </summary>
        Bronze,
        /// <summary>
        /// Challenge has silver badge
        /// </summary>
        Silver,
        /// <summary>
        /// Challenge has gold badge
        /// </summary>
        Gold,
        /// <summary>
        /// Challenge has platinum badge
        /// </summary>
        Platinum,
        /// <summary>
        /// Challenge has diamond badge
        /// </summary>
        Diamond,
        /// <summary>
        /// Challenge has master badge
        /// </summary>
        Master,
        /// <summary>
        /// Challenge has grandmaster badge
        /// </summary>
        Grandmaster,
        /// <summary>
        /// Challenge has challenger badge
        /// </summary>
        Challenger
    }

    /// <summary>
    /// Contains static extension methods for <see cref="LeagueChallengeLevel"/>
    /// </summary>
    public static class LeagueChallengeLevelExtensions
    {
        private const string None = "NONE";
        private const string Iron = "IRON";
        private const string Bronze = "BRONZE";
        private const string Silver = "SILVER";
        private const string Gold = "GOLD";
        private const string Platinum = "PLATINUM";
        private const string Diamond = "DIAMOND";
        private const string Master = "MASTER";
        private const string Grandmaster = "GRANDMASTER";
        private const string Challenger = "CHALLENGER";

        /// <summary>
        /// Gets corresponding string for <see cref="LeagueChallengeLevel"/> value
        /// </summary>
        /// <param name="level">League of Legends challenge level</param>
        /// <returns>A corresponding <see langword="string"/> for specified value</returns>
        /// <exception cref="ArgumentException">When unknown value is selected</exception>
        public static string GetStringFor(this LeagueChallengeLevel level)
        {
            switch (level)
            {
                case LeagueChallengeLevel.None:
                    return None;
                case LeagueChallengeLevel.Iron:
                    return Iron;
                case LeagueChallengeLevel.Bronze:
                    return Bronze;
                case LeagueChallengeLevel.Silver:
                    return Silver;
                case LeagueChallengeLevel.Gold:
                    return Gold;
                case LeagueChallengeLevel.Platinum:
                    return Platinum;
                case LeagueChallengeLevel.Diamond:
                    return Diamond;
                case LeagueChallengeLevel.Master:
                    return Master;
                case LeagueChallengeLevel.Grandmaster:
                    return Grandmaster;
                case LeagueChallengeLevel.Challenger:
                    return Challenger;
                default:
                    throw new ArgumentException("Unknown challenge level value selected", nameof(level));
            }
        }

        internal static LeagueChallengeLevel GetLeagueChallengeLevelFromString(this string str)
        {
            switch (str)
            {
                default:
                    return LeagueChallengeLevel.None;
                case Iron:
                    return LeagueChallengeLevel.Iron;
                case Bronze:
                    return LeagueChallengeLevel.Bronze;
                case Silver:
                    return LeagueChallengeLevel.Silver;
                case Gold:
                    return LeagueChallengeLevel.Gold;
                case Platinum:
                    return LeagueChallengeLevel.Platinum;
                case Diamond:
                    return LeagueChallengeLevel.Diamond;
                case Master:
                    return LeagueChallengeLevel.Master;
                case Grandmaster:
                    return LeagueChallengeLevel.Grandmaster;
                case Challenger:
                    return LeagueChallengeLevel.Challenger;
            }
        }
    }
}
