using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a League of Legends challenges collection
    /// </summary>
    public class LeagueChallengeCollection : List<LeagueChallenge>
    {
        /// <summary>
        /// Gets a League of Legends challenge by specified ID
        /// </summary>
        /// <param name="challengeId">League of Legends challenge ID</param>
        /// <returns><see cref="LeagueChallenge"/> with specified ID or <see langword="null"/></returns>
        public LeagueChallenge GetChallengeById(int challengeId)
        {
            return this.FirstOrDefault(c => c.Id == challengeId);
        }
    }
}
