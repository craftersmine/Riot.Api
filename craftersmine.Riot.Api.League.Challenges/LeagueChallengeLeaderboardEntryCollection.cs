using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a collection of League of Legends challenge leaderboard entries
    /// </summary>
    public class LeagueChallengeLeaderboardEntryCollection : List<LeagueChallengeLeaderboardEntry>
    {
        /// <summary>
        /// Gets a League of Legends challenge leaderboard entry for specified player with PUUID
        /// </summary>
        /// <param name="puuid">Riot Account PUUID</param>
        /// <returns><see cref="LeagueChallengeLeaderboardEntry"/> if entry exists for player with specified PUUID or <see langword="null"/></returns>
        public LeagueChallengeLeaderboardEntry this[string puuid] => this.FirstOrDefault(e => e.Puuid == puuid);
    }
}
