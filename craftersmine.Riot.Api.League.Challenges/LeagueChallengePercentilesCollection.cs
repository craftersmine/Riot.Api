using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a collection of League of Legends challenges ranking percentiles
    /// </summary>
    public class LeagueChallengePercentilesCollection : Dictionary<int, LeagueChallengePercentiles>
    {
        /// <summary>
        /// Gets a League of Legends challenge percentiles by specified challenge ID
        /// </summary>
        /// <param name="challengeId">League of Legends challenge ID</param>
        /// <returns><see cref="LeagueChallengePercentiles"/> for specified challenge ID</returns>
        public new LeagueChallengePercentiles this[int challengeId]
        {
            get => base[challengeId];

            private set => base[challengeId] = value;
        }
    }
}
