using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents current League of Legends challenge status
    /// </summary>
    public enum LeagueChallengeState
    {
        /// <summary>
        /// Unknown state
        /// </summary>
        Unknown,
        /// <summary>
        /// Challenge not visible and not calculated
        /// </summary>
        Disabled,
        /// <summary>
        /// Challenge not visible but being calculated
        /// </summary>
        Hidden,
        /// <summary>
        /// Challenge is visible and being calculated
        /// </summary>
        Enabled,
        /// <summary>
        /// Challenge is visible but not calculated
        /// </summary>
        Archived
    }

    /// <summary>
    /// Contains static extension methods for <see cref="LeagueChallengeState"/>
    /// </summary>
    public static class LeagueChallengeStateExtensions
    {
        private const string Disabled = "DISABLED";
        private const string Hidden = "HIDDEN";
        private const string Enabled = "ENABLED";
        private const string Archived = "ARCHIVED";

        /// <summary>
        /// Gets corresponding string for <see cref="LeagueChallengeState"/> value
        /// </summary>
        /// <param name="state">League of Legends challenge state</param>
        /// <returns>A corresponding <see langword="string"/> for specified value</returns>
        /// <exception cref="ArgumentException">When unknown value is selected</exception>
        public static string GetStringFor(this LeagueChallengeState state)
        {
            switch (state)
            {
                case LeagueChallengeState.Disabled:
                    return Disabled;
                case LeagueChallengeState.Hidden:
                    return Hidden;
                case LeagueChallengeState.Enabled:
                    return Enabled;
                case LeagueChallengeState.Archived:
                    return Archived;
                case LeagueChallengeState.Unknown:
                default:
                    throw new ArgumentException("Unknown League challenge state selected", nameof(state));
            }
        }

        internal static LeagueChallengeState GetLeagueChallengeStateFromString(this string str)
        {
            switch (str)
            {
                case Disabled:
                    return LeagueChallengeState.Disabled;
                case Hidden:
                    return LeagueChallengeState.Hidden;
                case Enabled:
                    return LeagueChallengeState.Enabled;
                case Archived:
                    return LeagueChallengeState.Archived;
                default:
                    return LeagueChallengeState.Unknown;
            }
        }
    }
}
