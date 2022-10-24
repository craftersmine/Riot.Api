using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a collection of League of Legends challenges information for player
    /// </summary>
    public class LeaguePlayerChallengeInfosCollection : List<LeaguePlayerChallengeInfo>
    {
        /// <summary>
        /// Gets a League of Legends challenge information with specified challenge ID for player
        /// </summary>
        /// <param name="challengeId">League of Legends challenge ID</param>
        /// <returns><see cref="LeaguePlayerChallengeInfo"/> with specified challenge ID or <see langword="null"/></returns>
        public new LeaguePlayerChallengeInfo this[int challengeId]
        {
            get
            {
                return this.FirstOrDefault(c => c.ChallengeId == challengeId);
            }

            private set => base[challengeId] = value;
        }
    }
}
