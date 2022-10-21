using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends challenges changes for match participant
    /// </summary>
    public class LeagueChallengesCollection : Dictionary<string, object>
    {
        /// <summary>
        /// Gets a challenge change value for specified challenge ID
        /// </summary>
        /// <typeparam name="T">Type of value for returning value</typeparam>
        /// <param name="challengeId">League of Legends challenge ID</param>
        /// <returns>A value with type of <see cref="T"/> for challenge change</returns>
        public T GetValueForChallengeAs<T>(string challengeId)
        {
            if (ContainsKey(challengeId))
                return (T) this[challengeId];

            return default;
        }
    }
}
