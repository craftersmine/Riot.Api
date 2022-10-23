using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a League of Legends challenges leaderboard entry
    /// </summary>
    public class LeagueChallengeLeaderboardEntry
    {
        /// <summary>
        /// Gets an overall leaderboard position of player for this challenge
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; private set; }
        /// <summary>
        /// Gets a Riot Games PUUID of player for this leaderboard entry
        /// </summary>
        [JsonProperty("puuid")]
        public string Puuid { get; private set; }
        /// <summary>
        /// Gets a current value of challenge of player for this challenge
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; private set; }
    }
}
