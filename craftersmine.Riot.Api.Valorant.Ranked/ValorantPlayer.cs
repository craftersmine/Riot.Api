using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Valorant.Ranked
{
    /// <summary>
    /// Represents a Valorant player
    /// </summary>
    public class ValorantPlayer
    {
        /// <summary>
        /// Gets a player's current competitive tier
        /// </summary>
        [JsonProperty("competitiveTier")]
        public int CompetitiveTier { get; private set; }
        /// <summary>
        /// Gets a player's current leaderboard rank
        /// </summary>
        [JsonProperty("leaderboardRank")]
        public long LeaderboardRank { get; private set; }
        /// <summary>
        /// Gets a player's current ranked rating
        /// </summary>
        [JsonProperty("rankedRating")]
        public long RankedRating { get; private set; }
        /// <summary>
        /// Gets a player's total number of wins
        /// </summary>
        [JsonProperty("numberOfWins")]
        public long NumberOfWins { get; private set; }
        /// <summary>
        /// Gets a player's Riot Account PUUID
        /// </summary>
        /// <remarks>
        /// This property can be <see langword="null"/> or empty if player is anonymized
        /// </remarks>
        [JsonProperty("puuid")]
        public string Puuid { get; private set; }
        /// <summary>
        /// Gets a player's Riot ID name
        /// </summary>
        /// <remarks>
        /// This property can be <see langword="null"/> or empty if player is anonymized
        /// </remarks>
        [JsonProperty("gameName")]
        public string GameName { get; private set; }
        /// <summary>
        /// Gets a player's Riot ID tag line
        /// </summary>
        /// <remarks>
        /// This property can be <see langword="null"/> or empty if player is anonymized
        /// </remarks>
        [JsonProperty("tagLine")]
        public string TagLine { get; private set; }
    }
}
