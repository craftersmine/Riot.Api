using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a League of Legends challenge tracking state
    /// </summary>
    public enum LeagueChallengeTrackingState
    {
        /// <summary>
        /// Unknown tracking state
        /// </summary>
        Unknown,
        /// <summary>
        /// Challenge being tracked forever
        /// </summary>
        Lifetime,
        /// <summary>
        /// Challenge being tracked only during current season
        /// </summary>
        Season
    }

    /// <summary>
    /// Contains static extension methods for <see cref="LeagueChallengeState"/>
    /// </summary>
    public static class LeagueChallengeTrackingStateExtensions
    {
        private const string Lifetime = "LIFETIME";
        private const string Season = "SEASON";
        
        /// <summary>
        /// Gets corresponding string for <see cref="LeagueChallengeTrackingState"/> value
        /// </summary>
        /// <param name="trackingState">League of Legends challenge tracking state</param>
        /// <returns>A corresponding <see langword="string"/> for specified value</returns>
        /// <exception cref="ArgumentException">When unknown value is selected</exception>
        public static string GetStringFor(this LeagueChallengeTrackingState trackingState)
        {
            switch (trackingState)
            {
                case LeagueChallengeTrackingState.Lifetime:
                    return Lifetime;
                case LeagueChallengeTrackingState.Season:
                    return Season;
                case LeagueChallengeTrackingState.Unknown:
                default:
                    throw new ArgumentException("Unknown value selected for League Challenge tracking state",
                        nameof(trackingState));
            }
        }

        internal static LeagueChallengeTrackingState GetLeagueChallengeTrackingStateFromString(this string str)
        {
            switch (str)
            {
                case Lifetime:
                    return LeagueChallengeTrackingState.Lifetime;
                case Season:
                    return LeagueChallengeTrackingState.Season;
                default:
                    return LeagueChallengeTrackingState.Unknown;
            }
        }
    }
}
